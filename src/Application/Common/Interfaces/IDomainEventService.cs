using System.Threading.Tasks;
using IdentityServerAngular.Domain.Common;

namespace IdentityServerAngular.Application.Common.Interfaces
{
    public interface IDomainEventService
    {
        Task Publish(DomainEvent domainEvent);
    }
}
