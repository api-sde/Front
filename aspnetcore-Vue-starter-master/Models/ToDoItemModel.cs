using System;

namespace Vue2Do.Models
{
    public class ToDoItemModel
    {
        public Guid Id { get; set; }

        public string Text { get; set; }

        public bool Completed { get; set; }
    }
}
