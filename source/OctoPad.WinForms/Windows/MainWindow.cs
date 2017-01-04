using System;
using System.Collections.Generic;
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

                var rootNodes = projectGroups.Select(projectGroup => new TreeNode(projectGroup.Name,
                    projectGroup.Projects.Select(project => new TreeNode(project.Name)).ToArray())).ToArray();

                foreach (var rootNode in rootNodes)
                {
                    rootNode.ExpandAll(); // Expand the root nodes instead of the treeview keeps the scroll position
                }

                projectsTreeView.Nodes.AddRange(rootNodes.ToArray());
            }
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            ShowLoginWindowClicked?.Invoke(sender, e);
        }

        public void ShowLoginWindow()
        {
            using (var loginWindow = new LoginWindow())
            {
                loginWindow.StartPosition = FormStartPosition.CenterParent;
                var result = loginWindow.ShowDialog();
                if (result == DialogResult.OK)
                {
                    AcquiredLoginCredentials?.Invoke(loginWindow.LoginCredentials, null);
                }
            }
        }

        public void ShowProgress(string message)
        {
            statusLabel.Text = message;
            statusLabel.Visible = true;
            statusProgressBar.Visible = true;
        }

        public void HideProgress(string message)
        {
            statusLabel.Text = message;
            statusLabel.Visible = true;
            statusProgressBar.Visible = false;
        }

        private void FilterTextBox_TextChanged(object sender, EventArgs e)
        {
            // TODO: Filter treeview on all nodes while keeping visually the correct node structure for matching nodes
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
    }
}
