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
    public class TableStructureItemRepository : IRepository<TableStructureItem>
    {
        public BaseReporter Create(TableStructureItem item)
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

        public IEnumerable<TableStructureItem> GetAll()
        {
            throw new NotImplementedException();
        }

        public TableStructureItem GetBook(int id)
        {
            throw new NotImplementedException();
        }

        public BaseReporter Update(TableStructureItem item)
        {
            throw new NotImplementedException();
        }
    }
}
