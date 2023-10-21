using TravelBuddyApi.Model;
using TravelBuddyApi.Repository;

namespace TravelBuddyApi.Services
{
    public class TodoItemService : ITodoItemService
    {
        readonly ITodoItemRepository _todoItemRepository;

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

        public TodoItem GetTodoItem(long id)
        {
            return _todoItemRepository.GetTodoItem(id);
        }
    }
}
