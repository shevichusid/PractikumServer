using Repositories.Entities;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public class ChildRepository : IChildRepository
    {
        IDataSource dataSource;
        public ChildRepository(IDataSource ds)
        {
            dataSource = ds;
        }
        public Child Add(Child model)
        {
            throw new NotImplementedException();
        }

        public void Delete(Child model)
        {
            throw new NotImplementedException();
        }

        public Child GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Child> GettAll()
        {
            throw new NotImplementedException();
        }

        public void Search(Child model)
        {
            throw new NotImplementedException();
        }

        public void Update(Child model)
        {
            throw new NotImplementedException();
        }
    }
}
