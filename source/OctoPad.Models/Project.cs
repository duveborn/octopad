using System.ComponentModel;

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
    }
}