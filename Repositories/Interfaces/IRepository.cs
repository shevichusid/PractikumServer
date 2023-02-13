﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces
{
    public interface IRepository<T>
    {
        Task<ICollection<T>> GetAllAsync();
        Task<T> GetByIdNumberAsync(string idNumber);
        Task<T> AddAsync(T model);
        Task<T> UpdateAsync(T model);
        Task DeleteAsync(string idNumber);
    }
}
