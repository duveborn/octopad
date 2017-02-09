using System;
using System.Windows.Forms;
using OctoPad.Repository.Octopus;
using OctoPad.Repository.Settings;
using OctoPad.UserInterface.MainWindow;
using OctoPad.WinForms.Windows;

namespace OctoPad.Startup
{ 
    static class Program
    {
        [STAThread]
        static void Main()
        {
            var view = new MainWindow();
            var repository = new OctoPadRepository();
            var settings = new SettingsRepository();
            var presenter = new MainWindowPresenter(view, repository, settings);

            Application.EnableVisualStyles();
            Application.Run(view);
        }
    }
}