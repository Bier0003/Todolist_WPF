using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todolist_WPF
{
   public class Todo
    {
        internal static string todoText1;

        public Todo() { }
        public Todo(int id, string todoText, DateTime dato, bool isCheck)
        {
            this.id = id;
            TodoText = todoText;
            Dato = dato;
            isCheck = isCheck;
        }

        public int id { get; set; }
        public string TodoText { get; set; }
        public DateTime Dato { get; set; }
       // public bool Checked { get; set; }
        public bool isCheck { get; set; }


       // public string NewText { get; set; }
        // public string OldText { get; set; }
    }
}
