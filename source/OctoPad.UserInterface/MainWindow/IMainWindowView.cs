using System;
using System.Collections.Generic;
using OctoPad.Models;

namespace OctoPad.UserInterface.MainWindow
{
    public interface IMainWindowView
    {
        List<ProjectGroup> ProjectGroups { get; set; }
        void ShowLoginWindow(LoginCredentials settingsLoginCredentials);
        void ShowProgress(string message);
        void HideProgress(string message);
        event EventHandler ShowLoginWindowClicked;
        event EventHandler AcquiredLoginCredentials;
    }
}