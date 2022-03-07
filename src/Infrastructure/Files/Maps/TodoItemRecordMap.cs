using CsvHelper.Configuration;
using System.Globalization;
using IdentityServerAngular.Application.TodoLists.Queries.ExportTodos;

namespace IdentityServerAngular.Infrastructure.Files.Maps
{
    public class TodoItemRecordMap : ClassMap<TodoItemRecord>
    {
        public TodoItemRecordMap()
        {
            AutoMap(CultureInfo.InvariantCulture);
            Map(m => m.Done).ConvertUsing(c => c.Done ? "Yes" : "No");
        }
    }
}
