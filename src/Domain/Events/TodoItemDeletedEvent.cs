using IdentityServerAngular.Domain.Common;
using IdentityServerAngular.Domain.Entities;

namespace IdentityServerAngular.Domain.Events
{
    public class TodoItemDeletedEvent : DomainEvent
    {
        public TodoItemDeletedEvent(TodoItem item)
        {
            Item = item;
        }

        public TodoItem Item { get; }
    }
}
