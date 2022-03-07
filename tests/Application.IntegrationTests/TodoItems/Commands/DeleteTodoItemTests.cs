using FluentAssertions;
using System.Threading.Tasks;
using IdentityServerAngular.Application.Common.Exceptions;
using IdentityServerAngular.Application.TodoItems.Commands.CreateTodoItem;
using IdentityServerAngular.Application.TodoItems.Commands.DeleteTodoItem;
using IdentityServerAngular.Application.TodoLists.Commands.CreateTodoList;
using IdentityServerAngular.Domain.Entities;
using NUnit.Framework;

namespace IdentityServerAngular.Application.IntegrationTests.TodoItems.Commands
{
    using static Testing;

    public class DeleteTodoItemTests : TestBase
    {
        [Test]
        public async Task ShouldRequireValidTodoItemId()
        {
            var command = new DeleteTodoItemCommand { Id = 99 };

            await FluentActions.Invoking(() =>
                SendAsync(command)).Should().ThrowAsync<NotFoundException>();
        }

        [Test]
        public async Task ShouldDeleteTodoItem()
        {
            var listId = await SendAsync(new CreateTodoListCommand
            {
                Title = "New List"
            });

            var itemId = await SendAsync(new CreateTodoItemCommand
            {
                ListId = listId,
                Title = "New Item"
            });

            await SendAsync(new DeleteTodoItemCommand
            {
                Id = itemId
            });

            var item = await FindAsync<TodoItem>(itemId);

            item.Should().BeNull();
        }
    }
}
