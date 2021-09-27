using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;


namespace Zadatak5i6
{
    class ToDoList
    {
        private List<Notes6> todoList;

        public ToDoList()
        {
            this.todoList = new List<Notes6>();
        }


        public void ToDoListAdd()
        {
            Notes6 element = new Notes6();
            Console.WriteLine("Unesite ime autora: ");
            element.Author = Console.ReadLine();
            Console.WriteLine("Unesite zabiljesku: ");
            element.NoteContent = Console.ReadLine();
            Console.WriteLine("Unesite razinu vaznosti 1-5: ");
            element.ImportanceLevel = Convert.ToInt32(Console.ReadLine());
            element.TimeStamp = DateTime.Now;

            this.todoList.Add(element);

            Console.WriteLine("Uneseno!");

        }
        public void ToDoListRemoveAt(int i)
        {
        
            this.todoList.RemoveAt(i);
            
        }

        public void ToDoListOutput()
        {
            foreach(Notes6 note in this.todoList)
            {
                Console.WriteLine(note.ToString());
                
            }
        }

        public void ToDoListFinishMax()
        {
            int n = 5;
            for(int i = 0; i < n; i++)
            {
                if(todoList[i].ImportanceLevel==5)
                {
                    todoList.RemoveAt(i);
                    n--;
                    i--;
                }

            }

        }

        internal List<Notes6> TodoList { get => todoList; set => todoList = value; }
    }
}
