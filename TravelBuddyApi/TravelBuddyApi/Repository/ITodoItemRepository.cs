using Microsoft.EntityFrameworkCore;
using TravelBuddyApi.Model;
namespace TravelBuddyApi.Repository
{
    public interface ITodoItemRepository : IDisposable
    {
        void InsertTodoItem(TodoItem todoItem);
        TodoItem GetTodoItem(long id);
        void DeleteTodoItem(long id);
        void EditTodoItem(TodoItem todoItem);
    }
}
