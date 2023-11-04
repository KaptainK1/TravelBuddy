using Microsoft.EntityFrameworkCore;
using EntityFramework.Exceptions;
using TravelBuddyApi.Model;
using TravelBuddyApi.Exceptions;
using System.Net;

namespace TravelBuddyApi.Repository
{
    public class TodoItemRepository : ITodoItemRepository
    {
        private readonly TodoContext _dbContext;

        public TodoItemRepository (TodoContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<TodoItem> DeleteTodoItem(long id)
        {
            TodoItem item = _dbContext.TodoItem.Where(x => x.Id.Equals(id)).First();
            if (item != null)
            {
                _dbContext.Remove(item);
                await _dbContext.SaveChangesAsync();
                return item;
            }
            throw new EntityValidationException(HttpStatusCode.Conflict, $"Cannot delete item with id {id}");
        }

        public async Task EditTodoItem(TodoItem todoItem)
        {
            var currentItem = _dbContext.TodoItem.Where (x => x.Id == todoItem.Id).FirstOrDefault();
            if (currentItem != null)
            {
                currentItem.Title = todoItem.Title;
                currentItem.Description = todoItem.Description;
                currentItem.Duration = todoItem.Duration;
                currentItem.IsDone = todoItem.IsDone;
                await _dbContext.SaveChangesAsync();
            }
            throw new EntityValidationException(HttpStatusCode.BadRequest, $"Cannot update item with id {todoItem.Id}");
        }

        public TodoItem GetTodoItem(long id)
        {
            return _dbContext.TodoItem.Where(x => x.Id.Equals(id)).FirstOrDefault();
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
