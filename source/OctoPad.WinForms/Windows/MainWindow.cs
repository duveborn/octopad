using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Controls;
using OctoPad.Models;
using OctoPad.UserInterface.MainWindow;

namespace OctoPad.WinForms.Windows
{
    public partial class MainWindow : Form, IMainWindowView
    {
        public event EventHandler ShowLoginWindowClicked;
        public event EventHandler AcquiredLoginCredentials;
        public event EventHandler SelectedProjectChanged;

        private List<ProjectGroup> projectGroups;

        public MainWindow()
        {
            InitializeComponent();
            projectGroups = new List<ProjectGroup>();
            Show();
        }

        public List<ProjectGroup> ProjectGroups
        {
            get
            {
                return projectGroups;
            }
            set
            {
                projectGroups = value;
                projectsTreeView.Nodes.Clear();

                var rootNodes = projectGroups.Select(
                    projectGroup => new TreeNode(projectGroup.Name, projectGroup.Projects.Select(
                        project => new TreeNode(project.Name) {Tag = project, ImageKey = @"project-ok", SelectedImageKey = @"project-ok"})
                        .ToArray()) {ImageKey = @"folder", SelectedImageKey = @"folder"})
                    .ToArray();

                foreach (var rootNode in rootNodes)
                {
                    rootNode.ExpandAll(); 
                }

                projectsTreeView.Nodes.AddRange(rootNodes.ToArray());
            }
        }

        public Project SelectedProject { get; set; }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            ShowLoginWindowClicked?.Invoke(sender, e);
        }

        public void ShowLoginWindow(LoginCredentials loginCredentials)
        {
            using (var loginWindow = new LoginWindow())
            {
                loginWindow.StartPosition = FormStartPosition.CenterParent;
                loginWindow.LoginCredentials = loginCredentials;

                var result = loginWindow.ShowDialog();
                if (result == DialogResult.OK)
                {
                    AcquiredLoginCredentials?.Invoke(loginWindow.LoginCredentials, null);
                }
            }
        }

        public void ShowProgress(string message)
        {
            projectsTreeSpinner.Visible = true;
            statusLabel.Text = message;
            statusLabel.Visible = true;
            statusProgressBar.Visible = true;
        }

        public void HideProgress(string message)
        {
            projectsTreeSpinner.Visible = false;
            statusLabel.Text = message;
            statusLabel.Visible = true;
            statusProgressBar.Visible = false;
        }

        private void FilterTextBox_TextChanged(object sender, EventArgs e)
        {
            var filteredRootNodes = projectGroups.Select(
                    projectGroup => new TreeNode(projectGroup.Name, projectGroup.Projects.Where(
                            project => CultureInfo.CurrentCulture.CompareInfo.IndexOf(project.Name, filterTextBox.Text, CompareOptions.IgnoreCase) >= 0).Select(
                            project => new TreeNode(project.Name) { Tag = project, ImageKey = @"project-ok", SelectedImageKey = @"project-ok" })
                        .ToArray()) { ImageKey = @"folder", SelectedImageKey = @"folder" }) 
                .ToList();

            filteredRootNodes.ForEach(node => node.ExpandAll());

            projectsTreeView.BeginUpdate();
            projectsTreeView.Nodes.Clear();
            projectsTreeView.Nodes.AddRange(filteredRootNodes.Where(rootNode => rootNode.Nodes.Count > 0).ToArray());
            projectsTreeView.EndUpdate();
        }

        private void FilterTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (!e.Control || (e.KeyCode != Keys.A))
            {
                return;
            }

            ((MetroTextBox) sender)?.SelectAll();
            e.Handled = true;
        }

        private void projectsTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            SelectedProject = projectsTreeView.SelectedNode.Tag as Project;

            if (SelectedProject != null)
            {
                SelectedProjectChanged?.Invoke(sender, e);
            }
        }

        public void ShowProjectDetails(string url)
        {
            projectWebBrowser.Navigate(url);
        }
    }
}
