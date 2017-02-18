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
                    Password = passwordTextBox.Text,
                    AuthenticationMethod = GetSelectedAuthenticationMethod()
                };
            }
            set
            {
                serverTextBox.Text = value.Server;
                apiKeyTextBox.Text = value.ApiKey;
                usernameTextBox.Text = value.Username;
                passwordTextBox.Text = value.Password;
                SetSelectedAuthenticationTab(value.AuthenticationMethod);
            }
        }

        private void SetSelectedAuthenticationTab(AuthenticationMethod authenticationMethod)
        {
            if (authenticationMethod == AuthenticationMethod.ApiKey)
            {
                loginTabControl.SelectedTab = apiKeyTab;
            }

            if (authenticationMethod == AuthenticationMethod.Username)
            {
                loginTabControl.SelectedTab = usernamePasswordTab;
            }
        }

        private AuthenticationMethod GetSelectedAuthenticationMethod()
        {
            if (loginTabControl.SelectedTab == apiKeyTab)
            {
                return AuthenticationMethod.ApiKey;
            }

            if (loginTabControl.SelectedTab == usernamePasswordTab)
            {
                return AuthenticationMethod.Username;
            }

            return AuthenticationMethod.Username;
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