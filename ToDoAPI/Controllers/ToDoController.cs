using Microsoft.AspNetCore.Mvc;
using ToDoAPI.Models;
using ToDoAPI.Services;

namespace ToDoAPI.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class ToDoController : ControllerBase
    {
        private readonly IToDoService _toDoService;

        public ToDoController(IToDoService toDoService)
        {
            _toDoService = toDoService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ToDoItem>> GetAll()
        {
            return Ok(_toDoService.GetAllItems());
        }

        [HttpGet("{id}")]
        public ActionResult<ToDoItem> GetById(int id)
        {
            var item = _toDoService.GetItemById(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpPost]
        public ActionResult<ToDoItem> Create(ToDoItem newItem)
        {
            var createdItem = _toDoService.CreateItem(newItem);
            return CreatedAtAction(nameof(GetById), new { id = createdItem.Id }, createdItem);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, ToDoItem updatedItem)
        {
            var result = _toDoService.UpdateItem(id, updatedItem);
            if (!result)
            {
                return NotFound();
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var result = _toDoService.DeleteItem(id);
            if (!result)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
