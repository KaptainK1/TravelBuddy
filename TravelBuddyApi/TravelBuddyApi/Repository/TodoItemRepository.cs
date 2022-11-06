using Microsoft.EntityFrameworkCore;
using EntityFramework.Exceptions;
using TravelBuddyApi.Model;
using TravelBuddyApi.Exceptions;

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
            throw new EntityValidationException("Error Deleting", $"Cannot delete item with id {id}");
        }

        public async Task EditTodoItem(TodoItem todoItem)
        {
            var currentItem = _dbContext.TodoItems.Where (x => x.Id == todoItem.Id).FirstOrDefault();
            if (currentItem != null)
            {
                currentItem.Title = todoItem.Title;
                currentItem.Description = todoItem.Description;
                currentItem.Duration = todoItem.Duration;
                currentItem.IsDone = todoItem.IsDone;
                await _dbContext.SaveChangesAsync();
            }
            throw new EntityValidationException("Error updating", $"Cannot update item with id {todoItem.Id}");
        }

        public async Task<TodoItem> GetTodoItem(long id)
        {
            return _dbContext.TodoItems.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public async Task InsertTodoItem(TodoItem todoItem)
        {
            _dbContext.Add(todoItem);
            await _dbContext.SaveChangesAsync();
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
