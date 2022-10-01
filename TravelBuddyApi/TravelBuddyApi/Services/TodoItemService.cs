using TravelBuddyApi.Model;
using TravelBuddyApi.Repository;

namespace TravelBuddyApi.Services
{
    public class TodoItemService : ITodoItemService
    {
        ITodoItemRepository _todoItemRepository;

        public TodoItemService(ITodoItemRepository todoItemRepository)
        {
            _todoItemRepository = todoItemRepository;
        }

        public async Task<TodoItem> DeleteTodoItem(long id)
        {
            var item = GetTodoItem(id);
            if (item != null)
            {
                return await _todoItemRepository.DeleteTodoItem(id);
            }
            return null;
        }

        public async Task<TodoItem> GetTodoItem(long id)
        {
            return await _todoItemRepository.GetTodoItem(id);
        }
    }
}
