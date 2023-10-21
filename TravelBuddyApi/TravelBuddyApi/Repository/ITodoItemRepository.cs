using Microsoft.EntityFrameworkCore;
using TravelBuddyApi.Model;
namespace TravelBuddyApi.Repository
{
    public interface ITodoItemRepository : IDisposable
    {
        Task InsertTodoItem(TodoItem todoItem);
        TodoItem GetTodoItem(long id);
        Task<TodoItem> DeleteTodoItem(long id);
        Task EditTodoItem(TodoItem todoItem);
    }
}
