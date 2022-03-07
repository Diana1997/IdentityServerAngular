using System.Collections.Generic;
using IdentityServerAngular.Domain.Common;
using IdentityServerAngular.Domain.ValueObjects;

namespace IdentityServerAngular.Domain.Entities
{
    public class TodoList : AuditableEntity
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public Colour Colour { get; set; } = Colour.White;

        public IList<TodoItem> Items { get; private set; } = new List<TodoItem>();
    }
}
