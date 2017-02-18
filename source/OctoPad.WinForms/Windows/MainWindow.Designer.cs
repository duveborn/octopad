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
            this.filterTextBox = new MetroFramework.Controls.MetroTextBox();
            this.projectWebBrowser = new System.Windows.Forms.WebBrowser();
            this.bottomStatusStrip = new System.Windows.Forms.StatusStrip();
            this.statusProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.leftPanel = new MetroFramework.Controls.MetroPanel();
            this.rightPanel = new MetroFramework.Controls.MetroPanel();
            this.projectTabControl = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.mainPanel = new MetroFramework.Controls.MetroPanel();
            this.bottomStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.projectTabControl.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // projectsTreeView
            // 
            this.projectsTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.projectsTreeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.projectsTreeView.ImageIndex = 0;
            this.projectsTreeView.ImageList = this.projectsIconsImageList;
            this.projectsTreeView.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.projectsTreeView.Location = new System.Drawing.Point(3, 54);
            this.projectsTreeView.Name = "projectsTreeView";
            this.projectsTreeView.SelectedImageIndex = 0;
            this.projectsTreeView.Size = new System.Drawing.Size(369, 703);
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
            this.connectButton.Location = new System.Drawing.Point(263, 3);
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
            this.filterTextBox.CustomButton.Location = new System.Drawing.Point(232, 1);
            this.filterTextBox.CustomButton.Name = "";
            this.filterTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.filterTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.filterTextBox.CustomButton.TabIndex = 1;
            this.filterTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.filterTextBox.CustomButton.UseSelectable = true;
            this.filterTextBox.CustomButton.Visible = false;
            this.filterTextBox.DisplayIcon = true;
            this.filterTextBox.Lines = new string[0];
            this.filterTextBox.Location = new System.Drawing.Point(3, 3);
            this.filterTextBox.MaxLength = 32767;
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.PasswordChar = '\0';
            this.filterTextBox.PromptText = "Search...";
            this.filterTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.filterTextBox.SelectedText = "";
            this.filterTextBox.SelectionLength = 0;
            this.filterTextBox.SelectionStart = 0;
            this.filterTextBox.ShortcutsEnabled = true;
            this.filterTextBox.ShowClearButton = true;
            this.filterTextBox.Size = new System.Drawing.Size(254, 23);
            this.filterTextBox.TabIndex = 1;
            this.filterTextBox.UseSelectable = true;
            this.filterTextBox.WaterMark = "Search...";
            this.filterTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.filterTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.filterTextBox.TextChanged += new System.EventHandler(this.FilterTextBox_TextChanged);
            this.filterTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FilterTextBox_KeyDown);
            // 
            // projectWebBrowser
            // 
            this.projectWebBrowser.Location = new System.Drawing.Point(360, 176);
            this.projectWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.projectWebBrowser.Name = "projectWebBrowser";
            this.projectWebBrowser.Size = new System.Drawing.Size(350, 176);
            this.projectWebBrowser.TabIndex = 1;
            // 
            // bottomStatusStrip
            // 
            this.bottomStatusStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.bottomStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusProgressBar,
            this.statusLabel});
            this.bottomStatusStrip.Location = new System.Drawing.Point(1094, 853);
            this.bottomStatusStrip.Name = "bottomStatusStrip";
            this.bottomStatusStrip.Size = new System.Drawing.Size(17, 22);
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
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = null;
            // 
            // leftPanel
            // 
            this.leftPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.leftPanel.Controls.Add(this.filterTextBox);
            this.leftPanel.Controls.Add(this.projectsTreeView);
            this.leftPanel.Controls.Add(this.connectButton);
            this.leftPanel.HorizontalScrollbarBarColor = true;
            this.leftPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.leftPanel.HorizontalScrollbarSize = 10;
            this.leftPanel.Location = new System.Drawing.Point(3, 6);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(375, 760);
            this.leftPanel.TabIndex = 5;
            this.leftPanel.VerticalScrollbarBarColor = true;
            this.leftPanel.VerticalScrollbarHighlightOnWheel = false;
            this.leftPanel.VerticalScrollbarSize = 10;
            // 
            // rightPanel
            // 
            this.rightPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rightPanel.Controls.Add(this.projectTabControl);
            this.rightPanel.HorizontalScrollbarBarColor = true;
            this.rightPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.rightPanel.HorizontalScrollbarSize = 10;
            this.rightPanel.Location = new System.Drawing.Point(384, 6);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(920, 757);
            this.rightPanel.TabIndex = 6;
            this.rightPanel.VerticalScrollbarBarColor = true;
            this.rightPanel.VerticalScrollbarHighlightOnWheel = false;
            this.rightPanel.VerticalScrollbarSize = 10;
            // 
            // projectTabControl
            // 
            this.projectTabControl.Controls.Add(this.metroTabPage1);
            this.projectTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectTabControl.Location = new System.Drawing.Point(0, 0);
            this.projectTabControl.Name = "projectTabControl";
            this.projectTabControl.SelectedIndex = 0;
            this.projectTabControl.Size = new System.Drawing.Size(920, 757);
            this.projectTabControl.TabIndex = 2;
            this.projectTabControl.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.projectWebBrowser);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(912, 715);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Web details";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.rightPanel);
            this.mainPanel.Controls.Add(this.leftPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.HorizontalScrollbarBarColor = true;
            this.mainPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mainPanel.HorizontalScrollbarSize = 10;
            this.mainPanel.Location = new System.Drawing.Point(20, 60);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1307, 766);
            this.mainPanel.TabIndex = 7;
            this.mainPanel.VerticalScrollbarBarColor = true;
            this.mainPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mainPanel.VerticalScrollbarSize = 10;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 846);
            this.Controls.Add(this.bottomStatusStrip);
            this.Controls.Add(this.mainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Text = "OctoPad";
            this.bottomStatusStrip.ResumeLayout(false);
            this.bottomStatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.leftPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.projectTabControl.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton connectButton;
        private MetroFramework.Controls.MetroTextBox filterTextBox;
        private System.Windows.Forms.StatusStrip bottomStatusStrip;
        private System.Windows.Forms.ToolStripProgressBar statusProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private DoubleBufferedTreeView projectsTreeView;
        private System.Windows.Forms.WebBrowser projectWebBrowser;
        private System.Windows.Forms.ImageList projectsIconsImageList;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroPanel leftPanel;
        private MetroFramework.Controls.MetroPanel rightPanel;
        private MetroFramework.Controls.MetroPanel mainPanel;
        private MetroFramework.Controls.MetroTabControl projectTabControl;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
    }
}

