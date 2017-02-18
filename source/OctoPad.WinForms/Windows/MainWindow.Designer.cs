using System.Windows.Forms;
using MetroFramework;
using OctoPad.WinForms.Controls;

namespace OctoPad.WinForms.Windows
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.mainWindowSplitContainer = new System.Windows.Forms.SplitContainer();
            this.projectsTreeSpinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.projectsTreeView = new OctoPad.WinForms.Controls.DoubleBufferedTreeView();
            this.projectsIconsImageList = new System.Windows.Forms.ImageList(this.components);
            this.connectButton = new MetroFramework.Controls.MetroButton();
            this.filterTextBox = new MetroFramework.Controls.MetroTextBox();
            this.selectedProjectTabControl = new System.Windows.Forms.TabControl();
            this.projectTab = new System.Windows.Forms.TabPage();
            this.projectWebBrowser = new System.Windows.Forms.WebBrowser();
            this.releasesListView = new System.Windows.Forms.ListView();
            this.releaseColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bottomStatusStrip = new System.Windows.Forms.StatusStrip();
            this.statusProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.mainWindowSplitContainer)).BeginInit();
            this.mainWindowSplitContainer.Panel1.SuspendLayout();
            this.mainWindowSplitContainer.Panel2.SuspendLayout();
            this.mainWindowSplitContainer.SuspendLayout();
            this.selectedProjectTabControl.SuspendLayout();
            this.projectTab.SuspendLayout();
            this.bottomStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainWindowSplitContainer
            // 
            this.mainWindowSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainWindowSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainWindowSplitContainer.Name = "mainWindowSplitContainer";
            // 
            // mainWindowSplitContainer.Panel1
            // 
            this.mainWindowSplitContainer.Panel1.Controls.Add(this.projectsTreeSpinner);
            this.mainWindowSplitContainer.Panel1.Controls.Add(this.projectsTreeView);
            this.mainWindowSplitContainer.Panel1.Controls.Add(this.connectButton);
            this.mainWindowSplitContainer.Panel1.Controls.Add(this.filterTextBox);
            // 
            // mainWindowSplitContainer.Panel2
            // 
            this.mainWindowSplitContainer.Panel2.Controls.Add(this.selectedProjectTabControl);
            this.mainWindowSplitContainer.Size = new System.Drawing.Size(1347, 911);
            this.mainWindowSplitContainer.SplitterDistance = 362;
            this.mainWindowSplitContainer.TabIndex = 3;
            // 
            // projectsTreeSpinner
            // 
            this.projectsTreeSpinner.Location = new System.Drawing.Point(217, 321);
            this.projectsTreeSpinner.Maximum = 100;
            this.projectsTreeSpinner.Name = "projectsTreeSpinner";
            this.projectsTreeSpinner.Size = new System.Drawing.Size(16, 16);
            this.projectsTreeSpinner.TabIndex = 4;
            this.projectsTreeSpinner.UseSelectable = true;
            this.projectsTreeSpinner.Visible = false;
            // 
            // projectsTreeView
            // 
            this.projectsTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.projectsTreeView.ImageIndex = 0;
            this.projectsTreeView.ImageList = this.projectsIconsImageList;
            this.projectsTreeView.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.projectsTreeView.Location = new System.Drawing.Point(3, 27);
            this.projectsTreeView.Name = "projectsTreeView";
            this.projectsTreeView.SelectedImageIndex = 0;
            this.projectsTreeView.Size = new System.Drawing.Size(356, 884);
            this.projectsTreeView.TabIndex = 3;
            this.projectsTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.projectsTreeView_AfterSelect);
            // 
            // projectsIconsImageList
            // 
            this.projectsIconsImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("projectsIconsImageList.ImageStream")));
            this.projectsIconsImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.projectsIconsImageList.Images.SetKeyName(0, "project-ok");
            this.projectsIconsImageList.Images.SetKeyName(1, "folder");
            this.projectsIconsImageList.Images.SetKeyName(2, "folder-ok");
            this.projectsIconsImageList.Images.SetKeyName(3, "folder-error");
            this.projectsIconsImageList.Images.SetKeyName(4, "folder-disabled");
            // 
            // connectButton
            // 
            this.connectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.connectButton.Location = new System.Drawing.Point(250, 3);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(109, 23);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Connect...";
            this.connectButton.UseSelectable = true;
            this.connectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // filterTextBox
            // 
            this.filterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.filterTextBox.CustomButton.Image = null;
            this.filterTextBox.CustomButton.Location = new System.Drawing.Point(219, 1);
            this.filterTextBox.CustomButton.Name = "";
            this.filterTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.filterTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.filterTextBox.CustomButton.TabIndex = 1;
            this.filterTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.filterTextBox.CustomButton.UseSelectable = true;
            this.filterTextBox.CustomButton.Visible = false;
            this.filterTextBox.Lines = new string[0];
            this.filterTextBox.Location = new System.Drawing.Point(3, 3);
            this.filterTextBox.MaxLength = 32767;
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.PasswordChar = '\0';
            this.filterTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.filterTextBox.SelectedText = "";
            this.filterTextBox.SelectionLength = 0;
            this.filterTextBox.SelectionStart = 0;
            this.filterTextBox.Size = new System.Drawing.Size(241, 23);
            this.filterTextBox.TabIndex = 1;
            this.filterTextBox.UseSelectable = true;
            this.filterTextBox.WaterMark = "Search...";
            this.filterTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.filterTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.filterTextBox.TextChanged += new System.EventHandler(this.FilterTextBox_TextChanged);
            this.filterTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FilterTextBox_KeyDown);
            // 
            // selectedProjectTabControl
            // 
            this.selectedProjectTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedProjectTabControl.Controls.Add(this.projectTab);
            this.selectedProjectTabControl.Location = new System.Drawing.Point(3, 3);
            this.selectedProjectTabControl.Name = "selectedProjectTabControl";
            this.selectedProjectTabControl.SelectedIndex = 0;
            this.selectedProjectTabControl.Size = new System.Drawing.Size(975, 908);
            this.selectedProjectTabControl.TabIndex = 1;
            // 
            // projectTab
            // 
            this.projectTab.Controls.Add(this.projectWebBrowser);
            this.projectTab.Controls.Add(this.releasesListView);
            this.projectTab.Location = new System.Drawing.Point(4, 22);
            this.projectTab.Name = "projectTab";
            this.projectTab.Padding = new System.Windows.Forms.Padding(3);
            this.projectTab.Size = new System.Drawing.Size(967, 882);
            this.projectTab.TabIndex = 0;
            this.projectTab.Text = "Project";
            this.projectTab.UseVisualStyleBackColor = true;
            // 
            // projectWebBrowser
            // 
            this.projectWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectWebBrowser.Location = new System.Drawing.Point(3, 3);
            this.projectWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.projectWebBrowser.Name = "projectWebBrowser";
            this.projectWebBrowser.Size = new System.Drawing.Size(961, 876);
            this.projectWebBrowser.TabIndex = 1;
            // 
            // releasesListView
            // 
            this.releasesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.releaseColumnHeader});
            this.releasesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.releasesListView.FullRowSelect = true;
            this.releasesListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.releasesListView.HideSelection = false;
            this.releasesListView.Location = new System.Drawing.Point(3, 3);
            this.releasesListView.Name = "releasesListView";
            this.releasesListView.Size = new System.Drawing.Size(961, 876);
            this.releasesListView.TabIndex = 0;
            this.releasesListView.UseCompatibleStateImageBehavior = false;
            this.releasesListView.View = System.Windows.Forms.View.Details;
            // 
            // releaseColumnHeader
            // 
            this.releaseColumnHeader.Text = "Release";
            this.releaseColumnHeader.Width = 519;
            // 
            // bottomStatusStrip
            // 
            this.bottomStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusProgressBar,
            this.statusLabel});
            this.bottomStatusStrip.Location = new System.Drawing.Point(0, 914);
            this.bottomStatusStrip.Name = "bottomStatusStrip";
            this.bottomStatusStrip.Size = new System.Drawing.Size(1347, 22);
            this.bottomStatusStrip.TabIndex = 4;
            this.bottomStatusStrip.Text = "statusStrip1";
            // 
            // statusProgressBar
            // 
            this.statusProgressBar.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.statusProgressBar.MarqueeAnimationSpeed = 40;
            this.statusProgressBar.Name = "statusProgressBar";
            this.statusProgressBar.Size = new System.Drawing.Size(100, 16);
            this.statusProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.statusProgressBar.Visible = false;
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1347, 936);
            this.Controls.Add(this.bottomStatusStrip);
            this.Controls.Add(this.mainWindowSplitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "OctoPad";
            this.mainWindowSplitContainer.Panel1.ResumeLayout(false);
            this.mainWindowSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainWindowSplitContainer)).EndInit();
            this.mainWindowSplitContainer.ResumeLayout(false);
            this.selectedProjectTabControl.ResumeLayout(false);
            this.projectTab.ResumeLayout(false);
            this.bottomStatusStrip.ResumeLayout(false);
            this.bottomStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SplitContainer mainWindowSplitContainer;
        private MetroFramework.Controls.MetroButton connectButton;
        private MetroFramework.Controls.MetroTextBox filterTextBox;
        private System.Windows.Forms.StatusStrip bottomStatusStrip;
        private System.Windows.Forms.ToolStripProgressBar statusProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ListView releasesListView;
        private System.Windows.Forms.ColumnHeader releaseColumnHeader;
        private System.Windows.Forms.TabControl selectedProjectTabControl;
        private System.Windows.Forms.TabPage projectTab;
        private DoubleBufferedTreeView projectsTreeView;
        private System.Windows.Forms.WebBrowser projectWebBrowser;
        private MetroFramework.Controls.MetroProgressSpinner projectsTreeSpinner;
        private System.Windows.Forms.ImageList projectsIconsImageList;
    }
}

