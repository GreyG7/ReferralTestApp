using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemoUI
{
    public class ToDoItem
    {
        public ToDoItem(string title, bool isDone)
        {
            Title = title;
            IsDone = isDone;
        }

        public string Title { get; set; }
        public bool IsDone { get; set; }
    }
}
