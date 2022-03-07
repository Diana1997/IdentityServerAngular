using IdentityServerAngular.Domain.Common;
using IdentityServerAngular.Domain.Entities;

namespace IdentityServerAngular.Domain.Events
{
    public class TodoItemCreatedEvent : DomainEvent
    {
        public TodoItemCreatedEvent(TodoItem item)
        {
            Item = item;
        }

        public TodoItem Item { get; }
    }
}
