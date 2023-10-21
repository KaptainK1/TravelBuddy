using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TravelBuddyApi.Model;
using TravelBuddyApi.Services;

namespace TravelBuddyApi.TravelBuddy.Todo
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : ControllerBase
    {
        readonly ITodoItemService _todoItemService;

        public TodoController(ITodoItemService todoItemService)
        {
            _todoItemService = todoItemService;
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public async Task<IActionResult> GetTodoItem([FromRoute] long id)
        {
            var item =  _todoItemService.GetTodoItem(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
           
        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public async Task<IActionResult> DeleteTodoItem([FromRoute] long id)
        {
            var item = await _todoItemService.DeleteTodoItem(id);
            if (item != null)
            {
                return Ok(item);
            }
            return BadRequest();
        }
    }
}
