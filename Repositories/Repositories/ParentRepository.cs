using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Repositories.Entities;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Server.Repository.Entities;
namespace Repositories.Repositories
{
    public class ParentRepository : IParentRepository
    {
        IDataSource dataSource;
        public ParentRepository(IDataSource ds)
        {
            dataSource = ds;
        }
        public async Task<ICollection<Parent>> GetAllAsync()
        {
            return await dataSource.Parents.ToListAsync();
        }
        public async Task<Parent> GetByIdNumberAsync(string parentId)
        {
            return await dataSource.Parents.FirstOrDefaultAsync(u => u.ParentId == parentId);
        }
        public async Task<Parent> AddAsync(Parent model)
        {
            EntityEntry<Parent> userToReturn = dataSource.Parents.Add(model);
            await dataSource.SaveChangesAsync();
            return userToReturn.Entity;
        }
        public async Task<Parent> UpdateAsync(Parent model)
        {
            var entity = dataSource.Parents.Update(model);
            await dataSource.SaveChangesAsync();
            return entity.Entity;
        }
        public async Task DeleteAsync(string parentId)
        {
            dataSource.Parents.Remove(dataSource.Parents.FirstOrDefault(p => p.ParentId == parentId));
            await dataSource.SaveChangesAsync();
        }
    }
}
