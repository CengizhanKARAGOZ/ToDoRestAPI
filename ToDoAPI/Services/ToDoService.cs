using ToDoAPI.Data;
using ToDoAPI.Infrastructure;
using ToDoAPI.Models;

namespace ToDoAPI.Services;

public class ToDoService:IToDoService
{
    private readonly ToDoContext _context;

    public ToDoService(ToDoContext context)
    {
        _context = context;
    }

    public IEnumerable<ToDoItem> GetAllItems()
    {
        return _context.ToDoItems.ToList();
    }

    public ToDoItem GetItemById(int id)
    {
        return _context.ToDoItems.Find(id);
    }

    public ToDoItem CreateItem(ToDoItem newItem)
    {
        _context.ToDoItems.Add(newItem);
        _context.SaveChanges();
        return newItem;
    }

    public bool UpdateItem(int id, ToDoItem updatedItem)
    {
        var existingItem = _context.ToDoItems.Find(id);
        if (existingItem == null)
        {
            return false;
        }

        existingItem.Title = updatedItem.Title;
        existingItem.IsCompleted = updatedItem.IsCompleted;
        _context.SaveChanges();
        return true;
    }

    public bool DeleteItem(int id)
    {
        var item = _context.ToDoItems.Find(id);
        if (item == null)
        {
            return false;
        }

        _context.ToDoItems.Remove(item);
        _context.SaveChanges();
        return true;
    }
}