using System;
using System.Windows.Forms;
using OctoPad.Repository.Octopus;
using OctoPad.Repository.Settings;
using OctoPad.UserInterface.MainWindow;
using OctoPad.WinForms.Windows;
using Squirrel;

namespace OctoPad.Startup
{ 
    static class Program
    {
        static string updateUrl = "https://github.com/duveborn/octopad";

        [STAThread]
        static void Main()
        {
            var view = new MainWindow();
            var repository = new OctoPadRepository();
            var settings = new SettingsRepository();
            var presenter = new MainWindowPresenter(view, repository, settings);

            Application.EnableVisualStyles();
            Application.Run(view);

            Update();
        }

        private static async void Update()
        {
            try
            {
                using (var mgr = await UpdateManager.GitHubUpdateManager(updateUrl))
                {
                    var release = await mgr.UpdateApp();
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message + Environment.NewLine;
                if (ex.InnerException != null)
                {
                    message += ex.InnerException.Message;
                }

                MessageBox.Show(message);
            }
        }
    }
}