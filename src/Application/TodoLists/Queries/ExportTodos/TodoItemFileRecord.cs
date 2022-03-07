using IdentityServerAngular.Application.Common.Mappings;
using IdentityServerAngular.Domain.Entities;

namespace IdentityServerAngular.Application.TodoLists.Queries.ExportTodos
{
    public class TodoItemRecord : IMapFrom<TodoItem>
    {
        public string Title { get; set; }

        public bool Done { get; set; }
    }
}
