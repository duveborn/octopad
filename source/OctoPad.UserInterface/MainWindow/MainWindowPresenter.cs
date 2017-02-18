using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using OctoPad.Models;
using OctoPad.Repository;
using Release = OctoPad.Models.Release;

namespace OctoPad.UserInterface.MainWindow
{
    public class MainWindowPresenter
    {
        private readonly IMainWindowView view;
        private readonly IOctoPadRepository octopus;
        private readonly ISettingsRepository settings;

        public MainWindowPresenter(IMainWindowView view, IOctoPadRepository octopus, ISettingsRepository settings)
        {
            this.view = view;
            this.view.ShowLoginWindowClicked += View_ShowLoginWindowClicked;
            this.view.AcquiredLoginCredentials += View_AcquiredLoginCredentials;
            this.view.SelectedProjectChanged += View_SelectedProjectChanged;

            this.octopus = octopus;
            this.settings = settings;
        }

        private async Task<List<Release>> GetReleasesFromRepository(string projectId)
        {
            return await Task.Run(() => octopus.GetReleases(projectId));
        }

        private async void View_AcquiredLoginCredentials(object sender, EventArgs e)
        {
            view.ShowProgress("Connecting to server…");
            var loginCredentials = sender as LoginCredentials;

            if (loginCredentials == null)
            {
                OnFailedLogin(null);
            }

            var successfulLogin = await Task.Run(() => Connect(loginCredentials));

            if (successfulLogin)
            {
                OnSuccessfulLogin(loginCredentials);
            }
            else
            {
                OnFailedLogin(loginCredentials);
            }
        }

        private bool Connect(LoginCredentials loginCredentials)
        {
            switch (loginCredentials.AuthenticationMethod)
            {
                case AuthenticationMethod.ApiKey:
                    return octopus.Connect(loginCredentials?.Server, loginCredentials?.ApiKey);
                case AuthenticationMethod.Username:
                    return octopus.Connect(loginCredentials?.Server, loginCredentials?.Username, loginCredentials?.Password);
                default:
                    return false;
            }
        }

        private async void OnSuccessfulLogin(LoginCredentials loginCredentials)
        {
            settings.LoginCredentials = loginCredentials;

            var stopwatch = new Stopwatch();
            stopwatch.Start();
            view.ShowProgress("Loading projects…");
            var projectGroups = await GetProjectTree();
            view.ProjectGroups = projectGroups;
            stopwatch.Stop();
            view.HideProgress($"Loaded {projectGroups.Count} projects in {(int)stopwatch.Elapsed.TotalSeconds} seconds");
        }

        private void OnFailedLogin(LoginCredentials loginCredentials)
        {
            view.HideProgress("Connection failed");
            view.ShowLoginWindow(loginCredentials);
        }

        private async Task<List<ProjectGroup>> GetProjectTree()
        {
            return await Task.Run(() => octopus.GetProjectGroupTree());
        }

        private void View_ShowLoginWindowClicked(object sender, System.EventArgs e)
        {
            view.ShowLoginWindow(settings.LoginCredentials);
        }

        private void View_SelectedProjectChanged(object sender, System.EventArgs e)
        {
            var url = settings.LoginCredentials.Server + view.SelectedProject.Links.First(link => link.Name == "Web").Uri;

            view.ShowProjectDetails(url, view.SelectedProject.Name);
        }
    }
}
