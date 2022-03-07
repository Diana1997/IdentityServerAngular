using IdentityServerAngular.Domain.Common;
using IdentityServerAngular.Domain.Entities;

namespace IdentityServerAngular.Domain.Events
{
    public class TodoItemCompletedEvent : DomainEvent
    {
        public TodoItemCompletedEvent(TodoItem item)
        {
            Item = item;
        }

        public TodoItem Item { get; }
    }
}
