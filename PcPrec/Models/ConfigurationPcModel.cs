using System;
using System.Collections.Generic;

namespace API.Models
{
    public class ConfigurationPcModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public IEnumerable<ComponentModel> Components { get; set; }
    }
}
