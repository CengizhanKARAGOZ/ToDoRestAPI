using Microsoft.EntityFrameworkCore;
using ToDoAPI.Models;

namespace ToDoAPI.Data;

public class ToDoContext: DbContext
{
    public ToDoContext(DbContextOptions<ToDoContext> options) : base(options) { }

    public DbSet<ToDoItem> ToDoItems { get; set; }
}