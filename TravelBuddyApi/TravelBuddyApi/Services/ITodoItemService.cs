using TravelBuddyApi.Model;

namespace TravelBuddyApi.Services
{
    public interface ITodoItemService
    {
        TodoItem GetTodoItem(long id);
        Task<TodoItem> DeleteTodoItem(long id);


    }
}
