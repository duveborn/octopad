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
                    ApiKey = apiKeyTextBox.Text
                };
            }
            set
            {
                serverTextBox.Text = value.Server;
                apiKeyTextBox.Text = value.ApiKey;
            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}