using NUnit.Framework;
using SimpleApi.Models;

namespace SimpleApi.Tests.Models
{
    public class TodoItemTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void WhenCreatedShouldNotBeComplete()
        {
            var item = new TodoItem();
            Assert.IsFalse(item.IsComplete);
        }
    }
}