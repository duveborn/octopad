using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
//using DiffPlex;
//using DiffPlex.DiffBuilder;
using Newtonsoft.Json;
using OctoPad.Models;
using Octopus.Client;
using Octopus.Client.Model;
using Environment = OctoPad.Models.Environment;

namespace OctoPad.Repository.Octopus
{
    public class OctoPadRepository : IOctoPadRepository
    {
        private OctopusRepository repository;

        public bool IsConnected { get; private set; }

        public bool Connect(string server, string username, string password)
        {
            try
            {
                var endpoint = new OctopusServerEndpoint(server);
                repository = new OctopusRepository(endpoint);
                repository.Users.SignIn(new LoginCommand { Username = username, Password = password });
                IsConnected = true;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Connect(string server, string apikey)
        {
            try
            {
                var endpoint = new OctopusServerEndpoint(server, apikey);
                repository = new OctopusRepository(endpoint);
                IsConnected = true;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<ProjectGroup> GetProjectGroupTree()
        {
            if (!IsConnected)
            {
                throw new AuthenticationException("You need to connect to an Octopus server first");
            }

            //var machineResources = repository.Machines.FindAll();
            //var environmentResources = repository.Environments.FindAll().OrderBy(x => x.SortOrder);
            var projectResources = repository.Projects.FindAll(); // This is where most of the load time is spent
            var projectGroupResources = repository.ProjectGroups.FindAll();

            //var left = GetProjectSettingsAsJson(projectResources[1].Id);
            //var right = GetProjectSettingsAsJson(projectResources[2].Id);

            //SideBySideDiffBuilder builder = new SideBySideDiffBuilder(new Differ());
            //var test = builder.BuildDiffModel(left, right);
            //test.NewText.Lines[0].Text

            //var machines = machineResources.Select(m => new Machine
            //{
            //    Name = m.Name,
            //    IsDisabled = m.IsDisabled,
            //    Status = m.Status.ToString(),
            //    EnvironmentIds = m.EnvironmentIds.ToList()
            //}).ToList();

            //var environments = environmentResources.Select(e => new Environment
            //{
            //    Name = e.Name,
            //    Description = e.Description,
            //    Machines = new List<Machine>()
            //}).ToList();

            var projects = projectResources.Select(p => new Project
            {
                Name = p.Name,
                Id = p.Id,
                ProjectGroupId = p.ProjectGroupId,
                Links = p.Links.Select(link => new Link
                {
                    Name = link.Key,
                    Uri = link.Value
                }).ToList()
                //Environments = FilterEnvironments(environments, projectGroupResources, p.ProjectGroupId).ToList()
            }).ToList();

            var projectGroups = projectGroupResources.Select(group => new ProjectGroup
            {
                Name = group.Name,
                Id = group.Id,
                Projects = projects.Where(project => project.ProjectGroupId == group.Id),
            }).Where(projectGroup => projectGroup.Name != "All Projects").ToList();

            return projectGroups.ToList();
        }

        public List<ProjectGroup> GetDashboard()
        {
            if (!IsConnected)
            {
                throw new AuthenticationException("You need to connect to an Octopus server first");
            }

            var dashboardResource = repository.Dashboards.GetDashboard();

            var projects = dashboardResource.Projects.Select(p => new Project
            {
                Name = p.Name,
                Id = p.Id,
                ProjectGroupId = p.ProjectGroupId
            });

            var projectGroups = dashboardResource.ProjectGroups.Select(group => new ProjectGroup
            {
                Name = group.Name,
                Id = group.Id,
                Projects = projects.Where(project => project.ProjectGroupId == group.Id)
            });

            return projectGroups.ToList();
        }

        public List<ProjectGroup> GetProjectGroups()
        {
            if (!IsConnected)
            {
                throw new AuthenticationException("You need to connect to an Octopus server first");
            }

            var projectGroupResources = repository.ProjectGroups.FindAll();

            return projectGroupResources.Select(projectResource => new ProjectGroup
            {
                Name = projectResource.Name,
                Id = projectResource.Id
            }).ToList();
        }

        public List<Project> GetProjects()
        {
            if (!IsConnected)
            {
                throw new AuthenticationException("You need to connect to an Octopus server first");
            }

            var projectResources = repository.Projects.FindAll();

            return projectResources.Select(projectResource => new Project
            {
                Name = projectResource.Name,
                Id = projectResource.Id,
                Description = projectResource.Description,
                IsDisabled = projectResource.IsDisabled
            }).ToList();
        }

        public List<Project> GetProjects(string projectGroupId)
        {
            if (!IsConnected)
            {
                throw new AuthenticationException("You need to connect to an Octopus server first");
            }

            var projectGroup = repository.ProjectGroups.Get(projectGroupId);
            var projects = repository.ProjectGroups.GetProjects(projectGroup);

            return projects.Select(projectResource => new Project
            {
                Id = projectResource.Id,
                Name = projectResource.Name,
                Description = projectResource.Description,
                IsDisabled = projectResource.IsDisabled
            }).ToList();
        }

        public string GetProjectSettingsAsJson(string projectId)
        {
            if (!IsConnected)
            {
                throw new AuthenticationException("You need to connect to an Octopus server first");
            }

            var settingsJson = JsonConvert.SerializeObject(repository.Projects.Get(projectId));
            var processJson = JsonConvert.SerializeObject(repository.DeploymentProcesses.Get("deploymentprocess-" + projectId));

            return settingsJson + processJson;
        }

        public DeploymentProcess GetDeploymentProcess(string projectId)
        {
            if (!IsConnected)
            {
                throw new AuthenticationException("You need to connect to an Octopus server first");
            }

            var deploymentProcessResource = repository.DeploymentProcesses.Get(projectId);

            return new DeploymentProcess
            {
                Id = deploymentProcessResource.Id,
                Steps = deploymentProcessResource.Steps.Select(stepResource => new Step
                {
                    Id = stepResource.Id,
                    Name = stepResource.Name,
                }).ToList(),
                Version = deploymentProcessResource.Version
            };
        }

        public List<Machine> GetMachines()
        {
            if (!IsConnected)
            {
                throw new AuthenticationException("You need to connect to an Octopus server first");
            }

            var machineResources = repository.Machines.FindAll();

            return machineResources.Select(machineResource => new Machine
            {
                Name = machineResource.Name,
                IsDisabled = machineResource.IsDisabled
            }).ToList();
        }

        public List<Environment> GetEnvironments()
        {
            if (!IsConnected)
            {
                throw new AuthenticationException("You need to connect to an Octopus server first");
            }

            var environmentResources = repository.Environments.FindAll();

            return environmentResources.OrderBy(e => e.SortOrder).Select(environmentResource => new Environment
            {
                Name = environmentResource.Name,
                Id = environmentResource.Id
            }).ToList();
        }

        public List<Release> GetReleases()
        {
            if (!IsConnected)
            {
                throw new AuthenticationException("You need to connect to an Octopus server first");
            }

            var releases = repository.Releases.FindAll();

            return releases.Select(release => new Release
            {
                Id = release.Id,
                Version = release.Version
            }).ToList();
        }

        public List<Release> GetReleases(string projectId)
        {
            if (!IsConnected)
            {
                throw new AuthenticationException("You need to connect to an Octopus server first");
            }

            var project = repository.Projects.Get(projectId);
            var releases = repository.Projects.GetReleases(project);

            return releases.Items.Select(release => new Release
            {
                Id = release.Id,
                Version = release.Version
            }).ToList();
        }
    }
}
