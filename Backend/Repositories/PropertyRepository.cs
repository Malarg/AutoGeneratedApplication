using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Interfaces;
using Backend.Models;
using Infrastructure;

namespace Backend.Repositories
{
    public class PropertyRepository : IRepository<Property>
    {
        public BaseReporter Create(Property item)
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

        public IEnumerable<Property> GetAll()
        {
            throw new NotImplementedException();
        }

        public Property GetBook(int id)
        {
            throw new NotImplementedException();
        }

        public BaseReporter Update(Property item)
        {
            throw new NotImplementedException();
        }
    }
}
