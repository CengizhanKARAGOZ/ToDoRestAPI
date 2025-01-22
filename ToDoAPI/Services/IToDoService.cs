using ToDoAPI.Models;

namespace ToDoAPI.Services;

public interface IToDoService
{
    IEnumerable<ToDoItem> GetAllItems();
    ToDoItem GetItemById(int id);
    ToDoItem CreateItem(ToDoItem newItem);
    bool UpdateItem(int id, ToDoItem updatedItem);
    bool DeleteItem(int id);
}