using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vue2Do.Models;

namespace Vue2Do.Services
{
    public interface IToDoItemService
    {
        Task<IEnumerable<ToDoItemModel>> GetItems(string userId);

        Task AddItem(string userId, string text);

        Task UpdateItem(string userId, Guid id, ToDoItemModel updatedData);

        Task DeleteItem(string userId, Guid id);
    }
}
