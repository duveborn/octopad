namespace OctoPad.WinForms.Windows
{
    partial class LoginWindow
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
            this.serverTextBox = new MetroFramework.Controls.MetroTextBox();
            this.serverLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.apiKeyTextBox = new MetroFramework.Controls.MetroTextBox();
            this.cancelLink = new MetroFramework.Controls.MetroLink();
            this.connectButton = new MetroFramework.Controls.MetroButton();
            this.loginTabControl = new MetroFramework.Controls.MetroTabControl();
            this.usernamePasswordTab = new MetroFramework.Controls.MetroTabPage();
            this.passwordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.usernameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.apiKeyTab = new MetroFramework.Controls.MetroTabPage();
            this.apiKeyLinkLabel = new System.Windows.Forms.LinkLabel();
            this.loginTabControl.SuspendLayout();
            this.usernamePasswordTab.SuspendLayout();
            this.apiKeyTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // serverTextBox
            // 
            // 
            // 
            // 
            this.serverTextBox.CustomButton.Image = null;
            this.serverTextBox.CustomButton.Location = new System.Drawing.Point(227, 1);
            this.serverTextBox.CustomButton.Name = "";
            this.serverTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.serverTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.serverTextBox.CustomButton.TabIndex = 1;
            this.serverTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.serverTextBox.CustomButton.UseSelectable = true;
            this.serverTextBox.CustomButton.Visible = false;
            this.serverTextBox.Lines = new string[0];
            this.serverTextBox.Location = new System.Drawing.Point(72, 67);
            this.serverTextBox.MaxLength = 32767;
            this.serverTextBox.Name = "serverTextBox";
            this.serverTextBox.PasswordChar = '\0';
            this.serverTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.serverTextBox.SelectedText = "";
            this.serverTextBox.SelectionLength = 0;
            this.serverTextBox.SelectionStart = 0;
            this.serverTextBox.Size = new System.Drawing.Size(249, 23);
            this.serverTextBox.TabIndex = 0;
            this.serverTextBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.serverTextBox.UseSelectable = true;
            this.serverTextBox.WaterMark = "https://octopus-server";
            this.serverTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.serverTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // serverLabel
            // 
            this.serverLabel.AutoSize = true;
            this.serverLabel.Location = new System.Drawing.Point(19, 67);
            this.serverLabel.Name = "serverLabel";
            this.serverLabel.Size = new System.Drawing.Size(51, 19);
            this.serverLabel.TabIndex = 7;
            this.serverLabel.Text = "Server:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 6);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(55, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "API key:";
            // 
            // apiKeyTextBox
            // 
            // 
            // 
            // 
            this.apiKeyTextBox.CustomButton.Image = null;
            this.apiKeyTextBox.CustomButton.Location = new System.Drawing.Point(217, 1);
            this.apiKeyTextBox.CustomButton.Name = "";
            this.apiKeyTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.apiKeyTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.apiKeyTextBox.CustomButton.TabIndex = 1;
            this.apiKeyTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.apiKeyTextBox.CustomButton.UseSelectable = true;
            this.apiKeyTextBox.CustomButton.Visible = false;
            this.apiKeyTextBox.Lines = new string[0];
            this.apiKeyTextBox.Location = new System.Drawing.Point(63, 6);
            this.apiKeyTextBox.MaxLength = 32767;
            this.apiKeyTextBox.Name = "apiKeyTextBox";
            this.apiKeyTextBox.PasswordChar = '•';
            this.apiKeyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.apiKeyTextBox.SelectedText = "";
            this.apiKeyTextBox.SelectionLength = 0;
            this.apiKeyTextBox.SelectionStart = 0;
            this.apiKeyTextBox.Size = new System.Drawing.Size(239, 23);
            this.apiKeyTextBox.TabIndex = 6;
            this.apiKeyTextBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.apiKeyTextBox.UseSelectable = true;
            this.apiKeyTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.apiKeyTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cancelLink
            // 
            this.cancelLink.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelLink.Location = new System.Drawing.Point(164, 208);
            this.cancelLink.Name = "cancelLink";
            this.cancelLink.Size = new System.Drawing.Size(75, 23);
            this.cancelLink.TabIndex = 5;
            this.cancelLink.Text = "Cancel";
            this.cancelLink.UseSelectable = true;
            this.cancelLink.Click += new System.EventHandler(this.cancelLink_Click);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(246, 207);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 4;
            this.connectButton.Text = "Connect";
            this.connectButton.UseSelectable = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // loginTabControl
            // 
            this.loginTabControl.Controls.Add(this.usernamePasswordTab);
            this.loginTabControl.Controls.Add(this.apiKeyTab);
            this.loginTabControl.Location = new System.Drawing.Point(15, 96);
            this.loginTabControl.Name = "loginTabControl";
            this.loginTabControl.SelectedIndex = 1;
            this.loginTabControl.Size = new System.Drawing.Size(312, 105);
            this.loginTabControl.TabIndex = 3;
            this.loginTabControl.TabStop = false;
            this.loginTabControl.UseSelectable = true;
            // 
            // usernamePasswordTab
            // 
            this.usernamePasswordTab.Controls.Add(this.passwordTextBox);
            this.usernamePasswordTab.Controls.Add(this.metroLabel3);
            this.usernamePasswordTab.Controls.Add(this.usernameTextBox);
            this.usernamePasswordTab.Controls.Add(this.metroLabel2);
            this.usernamePasswordTab.HorizontalScrollbarBarColor = true;
            this.usernamePasswordTab.HorizontalScrollbarHighlightOnWheel = false;
            this.usernamePasswordTab.HorizontalScrollbarSize = 10;
            this.usernamePasswordTab.Location = new System.Drawing.Point(4, 38);
            this.usernamePasswordTab.Name = "usernamePasswordTab";
            this.usernamePasswordTab.Padding = new System.Windows.Forms.Padding(3);
            this.usernamePasswordTab.Size = new System.Drawing.Size(304, 63);
            this.usernamePasswordTab.TabIndex = 0;
            this.usernamePasswordTab.Text = "User";
            this.usernamePasswordTab.UseVisualStyleBackColor = true;
            this.usernamePasswordTab.VerticalScrollbarBarColor = true;
            this.usernamePasswordTab.VerticalScrollbarHighlightOnWheel = false;
            this.usernamePasswordTab.VerticalScrollbarSize = 10;
            // 
            // passwordTextBox
            // 
            // 
            // 
            // 
            this.passwordTextBox.CustomButton.Image = null;
            this.passwordTextBox.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.passwordTextBox.CustomButton.Name = "";
            this.passwordTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.passwordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwordTextBox.CustomButton.TabIndex = 1;
            this.passwordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passwordTextBox.CustomButton.UseSelectable = true;
            this.passwordTextBox.CustomButton.Visible = false;
            this.passwordTextBox.Lines = new string[0];
            this.passwordTextBox.Location = new System.Drawing.Point(83, 35);
            this.passwordTextBox.MaxLength = 32767;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '●';
            this.passwordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.SelectionLength = 0;
            this.passwordTextBox.SelectionStart = 0;
            this.passwordTextBox.Size = new System.Drawing.Size(219, 23);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passwordTextBox.UseSelectable = true;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passwordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(11, 35);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(66, 19);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "Password:";
            // 
            // usernameTextBox
            // 
            // 
            // 
            // 
            this.usernameTextBox.CustomButton.Image = null;
            this.usernameTextBox.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.usernameTextBox.CustomButton.Name = "";
            this.usernameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.usernameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.usernameTextBox.CustomButton.TabIndex = 1;
            this.usernameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.usernameTextBox.CustomButton.UseSelectable = true;
            this.usernameTextBox.CustomButton.Visible = false;
            this.usernameTextBox.Lines = new string[0];
            this.usernameTextBox.Location = new System.Drawing.Point(83, 6);
            this.usernameTextBox.MaxLength = 32767;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.PasswordChar = '\0';
            this.usernameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.usernameTextBox.SelectedText = "";
            this.usernameTextBox.SelectionLength = 0;
            this.usernameTextBox.SelectionStart = 0;
            this.usernameTextBox.Size = new System.Drawing.Size(137, 23);
            this.usernameTextBox.TabIndex = 0;
            this.usernameTextBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.usernameTextBox.UseSelectable = true;
            this.usernameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.usernameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 6);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(71, 19);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "Username:";
            // 
            // apiKeyTab
            // 
            this.apiKeyTab.Controls.Add(this.apiKeyLinkLabel);
            this.apiKeyTab.Controls.Add(this.apiKeyTextBox);
            this.apiKeyTab.Controls.Add(this.metroLabel1);
            this.apiKeyTab.HorizontalScrollbarBarColor = true;
            this.apiKeyTab.HorizontalScrollbarHighlightOnWheel = false;
            this.apiKeyTab.HorizontalScrollbarSize = 10;
            this.apiKeyTab.Location = new System.Drawing.Point(4, 38);
            this.apiKeyTab.Name = "apiKeyTab";
            this.apiKeyTab.Padding = new System.Windows.Forms.Padding(3);
            this.apiKeyTab.Size = new System.Drawing.Size(304, 63);
            this.apiKeyTab.TabIndex = 1;
            this.apiKeyTab.Text = "API key";
            this.apiKeyTab.UseVisualStyleBackColor = true;
            this.apiKeyTab.VerticalScrollbarBarColor = true;
            this.apiKeyTab.VerticalScrollbarHighlightOnWheel = false;
            this.apiKeyTab.VerticalScrollbarSize = 10;
            // 
            // apiKeyLinkLabel
            // 
            this.apiKeyLinkLabel.AutoSize = true;
            this.apiKeyLinkLabel.Location = new System.Drawing.Point(60, 32);
            this.apiKeyLinkLabel.Name = "apiKeyLinkLabel";
            this.apiKeyLinkLabel.Size = new System.Drawing.Size(129, 13);
            this.apiKeyLinkLabel.TabIndex = 10;
            this.apiKeyLinkLabel.TabStop = true;
            this.apiKeyLinkLabel.Text = "How to create an API key";
            this.apiKeyLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.apiKeyLinkLabel_LinkClicked);
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelLink;
            this.ClientSize = new System.Drawing.Size(341, 245);
            this.ControlBox = false;
            this.Controls.Add(this.loginTabControl);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.cancelLink);
            this.Controls.Add(this.serverLabel);
            this.Controls.Add(this.serverTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginWindow";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Connect to Octopus Deploy";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.loginTabControl.ResumeLayout(false);
            this.usernamePasswordTab.ResumeLayout(false);
            this.usernamePasswordTab.PerformLayout();
            this.apiKeyTab.ResumeLayout(false);
            this.apiKeyTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox serverTextBox;
        private MetroFramework.Controls.MetroLabel serverLabel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox apiKeyTextBox;
        private MetroFramework.Controls.MetroLink cancelLink;
        private MetroFramework.Controls.MetroButton connectButton;
        private MetroFramework.Controls.MetroTabControl loginTabControl;
        private MetroFramework.Controls.MetroTabPage usernamePasswordTab;
        private MetroFramework.Controls.MetroTabPage apiKeyTab;
        private MetroFramework.Controls.MetroTextBox usernameTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox passwordTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.LinkLabel apiKeyLinkLabel;
    }
}