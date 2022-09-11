using Microsoft.EntityFrameworkCore;
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

        public void DeleteTodoItem(long id)
        {
            TodoItem item = _dbContext.TodoItems.Where(x => x.Id.Equals(id)).FirstOrDefault();
            if (item != null)
            {
                _dbContext.Remove(item);
            }
        }

        public void EditTodoItem(TodoItem todoItem)
        {
            throw new NotImplementedException();
        }

        public TodoItem GetTodoItem(long id)
        {
            return _dbContext.TodoItems.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public void InsertTodoItem(TodoItem todoItem)
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
