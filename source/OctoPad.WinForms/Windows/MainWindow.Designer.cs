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
            this.projectsTreeView = new OctoPad.WinForms.Controls.DoubleBufferedTreeView();
            this.projectsIconsImageList = new System.Windows.Forms.ImageList(this.components);
            this.connectButton = new MetroFramework.Controls.MetroButton();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.leftPanel = new MetroFramework.Controls.MetroPanel();
            this.statusLabel = new MetroFramework.Controls.MetroLabel();
            this.statusProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.filterTextBox = new MetroFramework.Controls.MetroTextBox();
            this.rightPanel = new MetroFramework.Controls.MetroPanel();
            this.projectTabControl = new MetroFramework.Controls.MetroTabControl();
            this.projectTabContextMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel = new MetroFramework.Controls.MetroPanel();
            this.metroStyleExtender = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.themeComboBox = new MetroFramework.Controls.MetroComboBox();
            this.versionLabel = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.projectTabContextMenu.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // projectsTreeView
            // 
            this.projectsTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroStyleExtender.SetApplyMetroTheme(this.projectsTreeView, true);
            this.projectsTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.projectsTreeView.ImageIndex = 0;
            this.projectsTreeView.ImageList = this.projectsIconsImageList;
            this.projectsTreeView.Location = new System.Drawing.Point(4, 47);
            this.projectsTreeView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.projectsTreeView.Name = "projectsTreeView";
            this.projectsTreeView.SelectedImageIndex = 0;
            this.projectsTreeView.Size = new System.Drawing.Size(492, 806);
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
            this.connectButton.Location = new System.Drawing.Point(351, 4);
            this.connectButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(145, 36);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Connect...";
            this.connectButton.UseSelectable = true;
            this.connectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // leftPanel
            // 
            this.leftPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.leftPanel.Controls.Add(this.statusLabel);
            this.leftPanel.Controls.Add(this.statusProgressBar);
            this.leftPanel.Controls.Add(this.filterTextBox);
            this.leftPanel.Controls.Add(this.projectsTreeView);
            this.leftPanel.Controls.Add(this.connectButton);
            this.leftPanel.HorizontalScrollbarBarColor = true;
            this.leftPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.leftPanel.HorizontalScrollbarSize = 12;
            this.leftPanel.Location = new System.Drawing.Point(4, 7);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(500, 893);
            this.leftPanel.TabIndex = 5;
            this.leftPanel.VerticalScrollbarBarColor = true;
            this.leftPanel.VerticalScrollbarHighlightOnWheel = false;
            this.leftPanel.VerticalScrollbarSize = 13;
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(4, 862);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(45, 19);
            this.statusLabel.TabIndex = 5;
            this.statusLabel.Text = "Ready";
            // 
            // statusProgressBar
            // 
            this.statusProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.statusProgressBar.Location = new System.Drawing.Point(363, 861);
            this.statusProgressBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.statusProgressBar.Name = "statusProgressBar";
            this.statusProgressBar.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.statusProgressBar.Size = new System.Drawing.Size(133, 25);
            this.statusProgressBar.TabIndex = 4;
            this.statusProgressBar.Visible = false;
            // 
            // filterTextBox
            // 
            this.filterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.filterTextBox.CustomButton.Image = null;
            this.filterTextBox.CustomButton.Location = new System.Drawing.Point(307, 2);
            this.filterTextBox.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.filterTextBox.CustomButton.Name = "";
            this.filterTextBox.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.filterTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.filterTextBox.CustomButton.TabIndex = 1;
            this.filterTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.filterTextBox.CustomButton.UseSelectable = true;
            this.filterTextBox.CustomButton.Visible = false;
            this.filterTextBox.DisplayIcon = true;
            this.filterTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.filterTextBox.Icon = ((System.Drawing.Image)(resources.GetObject("filterTextBox.Icon")));
            this.filterTextBox.Lines = new string[0];
            this.filterTextBox.Location = new System.Drawing.Point(4, 4);
            this.filterTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.filterTextBox.MaxLength = 32767;
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.PasswordChar = '\0';
            this.filterTextBox.PromptText = "Search projects...";
            this.filterTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.filterTextBox.SelectedText = "";
            this.filterTextBox.SelectionLength = 0;
            this.filterTextBox.SelectionStart = 0;
            this.filterTextBox.ShortcutsEnabled = true;
            this.filterTextBox.ShowClearButton = true;
            this.filterTextBox.Size = new System.Drawing.Size(339, 34);
            this.filterTextBox.TabIndex = 1;
            this.filterTextBox.UseSelectable = true;
            this.filterTextBox.WaterMark = "Search projects...";
            this.filterTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.filterTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.filterTextBox.TextChanged += new System.EventHandler(this.FilterTextBox_TextChanged);
            this.filterTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FilterTextBox_KeyDown);
            // 
            // rightPanel
            // 
            this.rightPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rightPanel.Controls.Add(this.projectTabControl);
            this.rightPanel.HorizontalScrollbarBarColor = true;
            this.rightPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.rightPanel.HorizontalScrollbarSize = 12;
            this.rightPanel.Location = new System.Drawing.Point(512, 7);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(1378, 889);
            this.rightPanel.TabIndex = 6;
            this.rightPanel.VerticalScrollbarBarColor = true;
            this.rightPanel.VerticalScrollbarHighlightOnWheel = false;
            this.rightPanel.VerticalScrollbarSize = 13;
            // 
            // projectTabControl
            // 
            this.projectTabControl.ContextMenuStrip = this.projectTabContextMenu;
            this.projectTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectTabControl.Location = new System.Drawing.Point(0, 0);
            this.projectTabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.projectTabControl.Name = "projectTabControl";
            this.projectTabControl.Size = new System.Drawing.Size(1378, 889);
            this.projectTabControl.TabIndex = 2;
            this.projectTabControl.UseSelectable = true;
            // 
            // projectTabContextMenu
            // 
            this.projectTabContextMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.projectTabContextMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.projectTabContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.projectTabContextMenu.Name = "projectTabContextMenu";
            this.projectTabContextMenu.Size = new System.Drawing.Size(104, 26);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.rightPanel);
            this.mainPanel.Controls.Add(this.leftPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.HorizontalScrollbarBarColor = true;
            this.mainPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mainPanel.HorizontalScrollbarSize = 12;
            this.mainPanel.Location = new System.Drawing.Point(27, 74);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1894, 900);
            this.mainPanel.TabIndex = 7;
            this.mainPanel.VerticalScrollbarBarColor = true;
            this.mainPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mainPanel.VerticalScrollbarSize = 13;
            // 
            // themeComboBox
            // 
            this.themeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.themeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.themeComboBox.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.themeComboBox.FormattingEnabled = true;
            this.themeComboBox.ItemHeight = 19;
            this.themeComboBox.Items.AddRange(new object[] {
            "Light",
            "Dark"});
            this.themeComboBox.Location = new System.Drawing.Point(1753, 5);
            this.themeComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.themeComboBox.Name = "themeComboBox";
            this.themeComboBox.Size = new System.Drawing.Size(84, 25);
            this.themeComboBox.TabIndex = 11;
            this.themeComboBox.UseSelectable = true;
            this.themeComboBox.SelectedIndexChanged += new System.EventHandler(this.themeComboBox_SelectedIndexChanged);
            // 
            // versionLabel
            // 
            this.versionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(1698, 8);
            this.versionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(51, 19);
            this.versionLabel.TabIndex = 12;
            this.versionLabel.Text = "Version";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1948, 999);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.themeComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainWindow";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "OctoPad";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Shown += new System.EventHandler(this.MainWindow_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.projectTabContextMenu.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton connectButton;
        private MetroFramework.Controls.MetroTextBox filterTextBox;
        private DoubleBufferedTreeView projectsTreeView;
        private System.Windows.Forms.ImageList projectsIconsImageList;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroPanel leftPanel;
        private MetroFramework.Controls.MetroPanel rightPanel;
        private MetroFramework.Controls.MetroPanel mainPanel;
        private MetroFramework.Controls.MetroTabControl projectTabControl;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender;
        private MetroFramework.Controls.MetroLabel statusLabel;
        private MetroFramework.Controls.MetroProgressBar statusProgressBar;
        private MetroFramework.Controls.MetroContextMenu projectTabContextMenu;
        private ToolStripMenuItem closeToolStripMenuItem;
        private MetroFramework.Controls.MetroComboBox themeComboBox;
        private MetroFramework.Controls.MetroLabel versionLabel;
    }
}

