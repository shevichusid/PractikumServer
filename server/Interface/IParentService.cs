using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IParentService
    {
       // Task<ICollection<ParentModel>> GetAllAsync();
        Task<ParentModel> GetByIdNumberAsync(string idNumber);
        Task<ParentModel> AddAsync(ParentModel model);
        Task<ParentModel> UpdateAsync(ParentModel model);
        Task DeleteAsync(string idNumber);
    }
}
