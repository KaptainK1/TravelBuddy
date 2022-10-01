using TravelBuddyApi.Model;

namespace TravelBuddyApi.Services
{
    public interface ITodoItemService
    {
        Task<TodoItem> GetTodoItem(long id);
        Task<TodoItem> DeleteTodoItem(long id);


    }
}
