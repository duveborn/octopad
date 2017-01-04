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
            this.SuspendLayout();
            // 
            // serverTextBox
            // 
            // 
            // 
            // 
            this.serverTextBox.CustomButton.Image = null;
            this.serverTextBox.CustomButton.Location = new System.Drawing.Point(217, 1);
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
            this.serverTextBox.Size = new System.Drawing.Size(239, 23);
            this.serverTextBox.TabIndex = 6;
            this.serverTextBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.serverTextBox.UseSelectable = true;
            this.serverTextBox.WaterMark = "https://octopus-server/api";
            this.serverTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.serverTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // serverLabel
            // 
            this.serverLabel.AutoSize = true;
            this.serverLabel.Location = new System.Drawing.Point(15, 67);
            this.serverLabel.Name = "serverLabel";
            this.serverLabel.Size = new System.Drawing.Size(51, 19);
            this.serverLabel.TabIndex = 7;
            this.serverLabel.Text = "Server:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(15, 96);
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
            this.apiKeyTextBox.Location = new System.Drawing.Point(72, 96);
            this.apiKeyTextBox.MaxLength = 32767;
            this.apiKeyTextBox.Name = "apiKeyTextBox";
            this.apiKeyTextBox.PasswordChar = '•';
            this.apiKeyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.apiKeyTextBox.SelectedText = "";
            this.apiKeyTextBox.SelectionLength = 0;
            this.apiKeyTextBox.SelectionStart = 0;
            this.apiKeyTextBox.Size = new System.Drawing.Size(239, 23);
            this.apiKeyTextBox.TabIndex = 8;
            this.apiKeyTextBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.apiKeyTextBox.UseSelectable = true;
            this.apiKeyTextBox.WaterMark = "API-KMCUJO8GX**************";
            this.apiKeyTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.apiKeyTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cancelLink
            // 
            this.cancelLink.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelLink.Location = new System.Drawing.Point(155, 125);
            this.cancelLink.Name = "cancelLink";
            this.cancelLink.Size = new System.Drawing.Size(75, 23);
            this.cancelLink.TabIndex = 11;
            this.cancelLink.Text = "Cancel";
            this.cancelLink.UseSelectable = true;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(237, 124);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 12;
            this.connectButton.Text = "Connect";
            this.connectButton.UseSelectable = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelLink;
            this.ClientSize = new System.Drawing.Size(334, 167);
            this.ControlBox = false;
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.cancelLink);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.apiKeyTextBox);
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
    }
}