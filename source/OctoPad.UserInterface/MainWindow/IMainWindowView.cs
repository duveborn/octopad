using System;
using System.Collections.Generic;
using OctoPad.Models;

namespace OctoPad.UserInterface.MainWindow
{
    public interface IMainWindowView
    {
        List<ProjectGroup> ProjectGroups { get; set; }
        void ShowLoginWindow();
        void ShowProgress(string message);
        void HideProgress(string message);
        event EventHandler ShowLoginWindowClicked;
        event EventHandler AcquiredLoginCredentials;
    }
}