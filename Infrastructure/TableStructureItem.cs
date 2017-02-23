using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class TableStructureItem
    {
        public string TableName { get; set; }
        public Dictionary<string, Type> Properties { get; set; }
    }
}
