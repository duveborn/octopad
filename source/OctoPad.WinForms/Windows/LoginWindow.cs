using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using OctoPad.Models;
using OctoPad.UserInterface.LoginWindow;

namespace OctoPad.WinForms.Windows
{
    public partial class LoginWindow : MetroForm, ILoginWindow
    {
        public event EventHandler ConnectButtonClicked;

        public LoginWindow()
        {
            InitializeComponent();
        }

        public LoginCredentials LoginCredentials
        {
            get
            {
                return new LoginCredentials
                {
                    Server = serverTextBox.Text,
                    ApiKey = apiKeyTextBox.Text,
                    Username = usernameTextBox.Text,
                    Password = passwordTextBox.Text
                };
            }
            set
            {
                serverTextBox.Text = value.Server;
                apiKeyTextBox.Text = value.ApiKey;
                usernameTextBox.Text = value.Username;
                passwordTextBox.Text = value.Password;

                loginTabControl.SelectedTab = string.IsNullOrEmpty(value.Username) && !string.IsNullOrEmpty(value.ApiKey) ? apiKeyTab : usernamePasswordTab;
            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void cancelLink_Click(object sender, EventArgs e)
        {

        }

        private void apiKeyLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://octopus.com/docs/how-to/how-to-create-an-api-key");
        }
    }
}