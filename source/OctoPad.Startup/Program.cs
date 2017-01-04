using System;
using System.Windows.Forms;
using OctoPad.Repository.Octopus;
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
            var presenter = new MainWindowPresenter(view, repository);

            Application.EnableVisualStyles();
            Application.Run(view);
        }
    }
}