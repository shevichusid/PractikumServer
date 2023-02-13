using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories.Entities;
using Microsoft.EntityFrameworkCore;

namespace Repositories.Interfaces
{
    public interface IDataSource
    {
        DbSet<Child> Children { get; set; }
        DbSet<Parent> Parents { get; set; }
        abstract Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}
