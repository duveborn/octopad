using OctoPad.Repository.Octopus;
using Xunit;

namespace Tests
{
    public class RepositoryTests
    {
        [Fact]
        public void GetProjects_ShouldNotBeEmpty()
        {
            var client = new OctoPadRepository();
            client.Connect("https://octopus-server/api/", "API-ABC123*************");
            var projects = client.GetProjects();
            Assert.NotEmpty(projects);
        }

        [Fact]
        public void GetProjectDetails_ShouldNotBeEmpty()
        {
            var client = new OctoPadRepository();
            client.Connect("https://octopus-server/api/", "API-ABC123*************");
            //var projects = client.GetProjects();
            var projectDetails = client.GetProjects();
            Assert.NotEmpty(projectDetails);
        }
    }
}
