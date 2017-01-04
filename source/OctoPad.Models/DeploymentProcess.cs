using System.Collections.Generic;

namespace OctoPad.Models
{
    public class DeploymentProcess
    {
        public string Id { get; set; }
        public int Version { get; set; }
        public List<Step> Steps { get; set; }
    }
}