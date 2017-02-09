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
            this.mainWindowSplitContainer = new System.Windows.Forms.SplitContainer();
            this.projectsTreeView = new OctoPad.WinForms.Controls.DoubleBufferedTreeView();
            this.connectButton = new MetroFramework.Controls.MetroButton();
            this.filterTextBox = new MetroFramework.Controls.MetroTextBox();
            this.selectedProjectTabControl = new System.Windows.Forms.TabControl();
            this.releasesTab = new System.Windows.Forms.TabPage();
            this.releasesListView = new System.Windows.Forms.ListView();
            this.releaseColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.settingsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.mainWindowSplitContainer)).BeginInit();
            this.mainWindowSplitContainer.Panel1.SuspendLayout();
            this.mainWindowSplitContainer.Panel2.SuspendLayout();
            this.mainWindowSplitContainer.SuspendLayout();
            this.selectedProjectTabControl.SuspendLayout();
            this.releasesTab.SuspendLayout();
            this.settingsTab.SuspendLayout();
            this.statusStrip1.SuspendLayout();
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
            this.mainWindowSplitContainer.Panel1.Controls.Add(this.projectsTreeView);
            this.mainWindowSplitContainer.Panel1.Controls.Add(this.connectButton);
            this.mainWindowSplitContainer.Panel1.Controls.Add(this.filterTextBox);
            // 
            // mainWindowSplitContainer.Panel2
            // 
            this.mainWindowSplitContainer.Panel2.Controls.Add(this.selectedProjectTabControl);
            this.mainWindowSplitContainer.Size = new System.Drawing.Size(1002, 651);
            this.mainWindowSplitContainer.SplitterDistance = 469;
            this.mainWindowSplitContainer.TabIndex = 3;
            // 
            // projectsTreeView
            // 
            this.projectsTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.projectsTreeView.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.projectsTreeView.Location = new System.Drawing.Point(3, 27);
            this.projectsTreeView.Name = "projectsTreeView";
            this.projectsTreeView.Size = new System.Drawing.Size(463, 624);
            this.projectsTreeView.TabIndex = 3;
            // 
            // connectButton
            // 
            this.connectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.connectButton.Location = new System.Drawing.Point(357, 3);
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
            this.filterTextBox.CustomButton.Location = new System.Drawing.Point(326, 1);
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
            this.filterTextBox.Size = new System.Drawing.Size(348, 23);
            this.filterTextBox.TabIndex = 1;
            this.filterTextBox.UseSelectable = true;
            this.filterTextBox.WaterMark = "Filter projects";
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
            this.selectedProjectTabControl.Controls.Add(this.releasesTab);
            this.selectedProjectTabControl.Controls.Add(this.settingsTab);
            this.selectedProjectTabControl.Location = new System.Drawing.Point(3, 3);
            this.selectedProjectTabControl.Name = "selectedProjectTabControl";
            this.selectedProjectTabControl.SelectedIndex = 0;
            this.selectedProjectTabControl.Size = new System.Drawing.Size(523, 648);
            this.selectedProjectTabControl.TabIndex = 1;
            // 
            // releasesTab
            // 
            this.releasesTab.Controls.Add(this.releasesListView);
            this.releasesTab.Location = new System.Drawing.Point(4, 22);
            this.releasesTab.Name = "releasesTab";
            this.releasesTab.Padding = new System.Windows.Forms.Padding(3);
            this.releasesTab.Size = new System.Drawing.Size(515, 622);
            this.releasesTab.TabIndex = 0;
            this.releasesTab.Text = "Releases";
            this.releasesTab.UseVisualStyleBackColor = true;
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
            this.releasesListView.Size = new System.Drawing.Size(509, 616);
            this.releasesListView.TabIndex = 0;
            this.releasesListView.UseCompatibleStateImageBehavior = false;
            this.releasesListView.View = System.Windows.Forms.View.Details;
            // 
            // releaseColumnHeader
            // 
            this.releaseColumnHeader.Text = "Release";
            this.releaseColumnHeader.Width = 519;
            // 
            // settingsTab
            // 
            this.settingsTab.Controls.Add(this.settingsRichTextBox);
            this.settingsTab.Location = new System.Drawing.Point(4, 22);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTab.Size = new System.Drawing.Size(515, 622);
            this.settingsTab.TabIndex = 1;
            this.settingsTab.Text = "Settings";
            this.settingsTab.UseVisualStyleBackColor = true;
            // 
            // settingsRichTextBox
            // 
            this.settingsRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsRichTextBox.Location = new System.Drawing.Point(3, 3);
            this.settingsRichTextBox.Name = "settingsRichTextBox";
            this.settingsRichTextBox.ReadOnly = true;
            this.settingsRichTextBox.Size = new System.Drawing.Size(509, 616);
            this.settingsRichTextBox.TabIndex = 0;
            this.settingsRichTextBox.Text = "";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusProgressBar,
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 654);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1002, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusProgressBar
            // 
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
            this.ClientSize = new System.Drawing.Size(1002, 676);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mainWindowSplitContainer);
            this.Name = "MainWindow";
            this.Text = "OctoPad";
            this.mainWindowSplitContainer.Panel1.ResumeLayout(false);
            this.mainWindowSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainWindowSplitContainer)).EndInit();
            this.mainWindowSplitContainer.ResumeLayout(false);
            this.selectedProjectTabControl.ResumeLayout(false);
            this.releasesTab.ResumeLayout(false);
            this.settingsTab.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SplitContainer mainWindowSplitContainer;
        private MetroFramework.Controls.MetroButton connectButton;
        private MetroFramework.Controls.MetroTextBox filterTextBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar statusProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ListView releasesListView;
        private System.Windows.Forms.ColumnHeader releaseColumnHeader;
        private System.Windows.Forms.TabControl selectedProjectTabControl;
        private System.Windows.Forms.TabPage releasesTab;
        private System.Windows.Forms.TabPage settingsTab;
        private System.Windows.Forms.RichTextBox settingsRichTextBox;
        private DoubleBufferedTreeView projectsTreeView;
    }
}

