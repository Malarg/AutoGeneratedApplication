using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class Property
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public Property()
        {

        }

        public Property(string name, string type)
        {
            Name = name;
            Type = type;
        }
    }
}
