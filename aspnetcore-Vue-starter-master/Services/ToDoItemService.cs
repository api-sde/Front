using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vue2Do.Models;

namespace Vue2Do.Services
{
    public class ToDoItemService : IToDoItemService
    {
        public Task<IEnumerable<ToDoItemModel>> GetItems(string userId)
        {
            List<ToDoItemModel> todos = new List<ToDoItemModel>
            {
                new ToDoItemModel { Text = "Fake Test Service ToDo", Completed = true},
                new ToDoItemModel { Text = "Fake Test Service ToDo", Completed = false},
            };

            return Task.FromResult(todos.AsEnumerable());
        }

        public Task AddItem(string userId, string text)
        {
            throw new NotImplementedException();
        }

        public Task DeleteItem(string userId, Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateItem(string userId, Guid id, ToDoItemModel updatedData)
        {
            throw new NotImplementedException();
        }
    }
}
