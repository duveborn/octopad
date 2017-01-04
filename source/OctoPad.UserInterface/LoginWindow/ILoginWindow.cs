using System;
using OctoPad.Models;

namespace OctoPad.UserInterface.LoginWindow
{
    public interface ILoginWindow
    {
        LoginCredentials LoginCredentials { get; set; }
        event EventHandler ConnectButtonClicked;
    }
}