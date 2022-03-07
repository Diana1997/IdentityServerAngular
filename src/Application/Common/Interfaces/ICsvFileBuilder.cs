using System.Collections.Generic;
using IdentityServerAngular.Application.TodoLists.Queries.ExportTodos;

namespace IdentityServerAngular.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}
