using System.Collections.Generic;
using System.ComponentModel;

namespace OctoPad.Models
{
    public class Machine
    {
        public string Name { get; set; }
        [Browsable(false)]
        public bool IsDisabled { get; set; }
        [Browsable(false)]
        public string Status { get; set; }
        [Browsable(false)]
        public List<string> EnvironmentIds { get; set; }
    }
}