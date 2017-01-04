using System.Collections.Generic;
using OctoPad.Models;

namespace OctoPad.Repository
{
    public interface IOctoPadRepository
    {
        bool Connect(string server, string apikey);
        bool Connect(string server, string username, string password);
        bool IsConnected { get; }
        List<Project> GetProjects();
        List<Release> GetReleases(string projectId);
        List<ProjectGroup> GetDashboard();
        List<Release> GetReleases();
        List<Project> GetProjects(string projectGroupId);
        List<ProjectGroup> GetProjectGroups();
        List<ProjectGroup> GetProjectGroupTree();
    }
}