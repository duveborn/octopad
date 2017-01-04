using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using OctoPad.Models;
using OctoPad.Repository;
using Release = OctoPad.Models.Release;

namespace OctoPad.UserInterface.MainWindow
{
    public class MainWindowPresenter
    {
        private readonly IMainWindowView view;
        private readonly IOctoPadRepository repository;
        private LoginCredentials loginCredentials;

        public MainWindowPresenter(IMainWindowView view, IOctoPadRepository repository)
        {
            this.view = view;
            this.view.ShowLoginWindowClicked += View_ShowLoginWindowClicked;
            this.view.AcquiredLoginCredentials += View_AcquiredLoginCredentials;

            this.repository = repository;
        }

        private async Task<List<Release>> GetReleasesFromRepository(string projectId)
        {
            return await Task.Run(() => repository.GetReleases(projectId));
        }

        private async void View_AcquiredLoginCredentials(object sender, System.EventArgs e)
        {
            loginCredentials = sender as LoginCredentials;
            
            if(!repository.Connect(loginCredentials?.Server, loginCredentials?.ApiKey))
            {
                view.ShowLoginWindow();
            }
            else
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                view.ShowProgress("Loading projects");
                var projectGroups = await GetProjectTree();
                view.ProjectGroups = projectGroups;
                stopwatch.Stop();
                view.HideProgress($"Loaded {projectGroups.Count} projects in {(int) stopwatch.Elapsed.TotalSeconds} seconds");
            }
        }

        private async Task<List<ProjectGroup>> GetProjectTree()
        {
            return await Task.Run(() => repository.GetProjectGroupTree());
        }

        private void View_ShowLoginWindowClicked(object sender, System.EventArgs e)
        {
            view.ShowLoginWindow();
        }
    }
}
