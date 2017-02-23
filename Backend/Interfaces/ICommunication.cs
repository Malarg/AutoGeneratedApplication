using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Models;

namespace Backend.Interfaces
{
    interface ICommunication
    {
        BaseReporter AddAttribute(string name, string type, string tableName);
        BaseReporter DeleteAttribute(string name, string tableName);
        BaseReporter AddTable(string name, Dictionary<string, string> properties);
        BaseReporter DeleteTable(string name);
    }
}
