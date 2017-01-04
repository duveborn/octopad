using System.Collections.Generic;
using System.ComponentModel;

namespace OctoPad.Models
{
    public class Environment
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Machine> Machines { get; set; }
        public string Id { get; set; }
    }
}