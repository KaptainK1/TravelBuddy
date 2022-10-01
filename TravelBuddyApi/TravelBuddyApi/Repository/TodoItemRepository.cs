using Microsoft.EntityFrameworkCore;
using EntityFramework.Exceptions;
using TravelBuddyApi.Model;

namespace TravelBuddyApi.Repository
{
    public class TodoItemRepository : ITodoItemRepository
    {
        private TodoContext _dbContext;

        public TodoItemRepository (TodoContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<TodoItem> DeleteTodoItem(long id)
        {
            TodoItem item = _dbContext.TodoItems.Where(x => x.Id.Equals(id)).FirstOrDefault();
            if (item != null)
            {
                _dbContext.Remove(item);
                await _dbContext.SaveChangesAsync();
                return item;
            }
            return null;
        }

        public Task EditTodoItem(TodoItem todoItem)
        {
            throw new NotImplementedException();
        }

        public async Task<TodoItem> GetTodoItem(long id)
        {
            return _dbContext.TodoItems.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public Task InsertTodoItem(TodoItem todoItem)
        {
            throw new NotImplementedException();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
