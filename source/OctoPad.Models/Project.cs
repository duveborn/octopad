using System.Collections.Generic;
using System.ComponentModel;
using Octopus.Client.Model;

namespace OctoPad.Models
{
    public class Project
    {
        public string Name { get; set; }
        [Browsable(false)]
        public string Id { get; set; }
        [Browsable(false)]
        public string ProjectGroupId { get; set; }
        [Browsable(false)]
        public string Description { get; set; }
        [Browsable(false)]
        public bool IsDisabled { get; set; }
        [Browsable(false)]
        public List<Link> Links { get; set; }
    }
}