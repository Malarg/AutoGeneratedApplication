using Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Interfaces
{
    interface IRepository<T> : IDisposable
        where T : class
    {
        IEnumerable<T> GetAll();
        T GetBook(int id);
        BaseReporter Create(T item);
        BaseReporter Update(T item);
        BaseReporter Delete(int id);
    }
}
