using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class DataItem
    {
        public string TableName { get; set; }
        public int RecordId { get; set; }
        public string PropertyName { get; set; }
        public object Value { get; set; }
    }
}
