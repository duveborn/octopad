using System.Collections.Generic;
using System.ComponentModel;

namespace OctoPad.Models
{
    public class ProjectGroup
    {
        public string Name { get; set; }
        public IEnumerable<Project> Projects { get; set; }
        public IEnumerable<Environment> Environments { get; set; }
        [Browsable(false)]
        public string Id { get; set; }
    }
}