using Backend.Interfaces;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Models;

namespace Backend.Repositories
{
    public class DataItemRepository : IRepository<DataItem>
    {
        public BaseReporter Create(DataItem item)
        {
            throw new NotImplementedException();
        }

        public BaseReporter Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DataItem> GetAll()
        {
            throw new NotImplementedException();
        }

        public DataItem GetBook(int id)
        {
            throw new NotImplementedException();
        }

        public BaseReporter Update(DataItem item)
        {
            throw new NotImplementedException();
        }
    }
}
