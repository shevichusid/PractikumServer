using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces
{
    public interface IParentRepository
    {
        Task<ICollection<Parent>> GetAllAsync();
        Task<Parent> GetByIdNumberAsync(string id);
        Task<Parent> AddAsync(Parent model);
        Task<Parent> UpdateAsync(Parent model);
        Task DeleteAsync(string idNumber);
    }
}
