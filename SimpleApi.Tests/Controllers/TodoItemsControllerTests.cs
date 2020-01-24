using System.Linq;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using SimpleApi.Controllers;
using SimpleApi.Models;

namespace SimpleApi.Tests.Controllers
{
    public class TodoItemsControllerTests
    {
        [Test]
        public void GetShouldReturnItems()
        {
            var optionsBuilder = new DbContextOptionsBuilder<TodoContext>();
            optionsBuilder.UseInMemoryDatabase("test.db");
            var efContext = new TodoContext(optionsBuilder.Options);
            var item = new TodoItem(){ Name= "item 1"};
            efContext.TodoItems.Add(item);
            efContext.SaveChanges();
            var controller = new TodoItemsController(efContext);
            
            var result =  controller.GetTodoItems();
            
            Assert.AreEqual(1, result.Result.Value.Count());
        }
    }
}