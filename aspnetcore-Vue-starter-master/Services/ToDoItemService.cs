using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vue2Do.Models;

namespace Vue2Do.Services
{
    public class ToDoItemService : IToDoItemService
    {
        private Dictionary<int, ToDoItemModel> todos;

        private void Initialize()
        {
            todos = todos ?? new Dictionary<int, ToDoItemModel>
            {
                { 0, new ToDoItemModel { Id = new Guid(), Text = "Fake Test Service ToDo", Completed = true} },
                { 1, new ToDoItemModel { Id = new Guid(), Text = "Fake Test Service ToDo", Completed = false} },
            };
        }

        public Task<IEnumerable<ToDoItemModel>> GetItems(string userId)
        {
            Initialize();

            return Task.FromResult(todos.Values.AsEnumerable());
        }

        public Task AddItem(string userId, string text)
        {
            todos.Add(todos.Max().Key + 1, new ToDoItemModel { Id = new Guid(), Text = text });
            return Task.CompletedTask;
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
