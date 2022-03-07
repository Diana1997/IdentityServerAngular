using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using IdentityServerAngular.Domain.Entities;

namespace IdentityServerAngular.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<TodoList> TodoLists { get; set; }

        DbSet<TodoItem> TodoItems { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
