using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Vue2Do.Services;

namespace Vue2Do.Controllers
{
    [Route("api/[controller]")]
    public class ToDoController : Controller
    {
        ToDoItemService _toDoItemService;

        private void Initialize()
        {
            _toDoItemService = _toDoItemService ?? new ToDoItemService();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTodos()
        {
            Initialize();

            var todos = await _toDoItemService.GetItems("123");

            return Ok(todos);
        }
    }
}
