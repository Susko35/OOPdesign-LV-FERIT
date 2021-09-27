using System;



namespace Dizajn_OOP_LV1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Zadaci 2 i 3
            Zadatak2i3.Notes2i3 objekt1= new Zadatak2i3.Notes2i3("autorGen", "zabljeskaGen", 4);
            Zadatak2i3.Notes2i3 objekt2 = new Zadatak2i3.Notes2i3();
            Zadatak2i3.Notes2i3 objekt3 = new Zadatak2i3.Notes2i3("autorGen3");
            //Zadatak 5 i 6
            Zadatak5i6.Notes6 objekt6 = new Zadatak5i6.Notes6("autorGenTime", "zabljeskaGenTime", 5,DateTime.Now);
            Console.WriteLine(objekt6.ToString());
            //Zadatak 7
            Zadatak5i6.ToDoList todoList = new Zadatak5i6.ToDoList();
            for(int i = 0; i < 5; i++)
            {
                todoList.ToDoListAdd();
            }

            todoList.ToDoListOutput();
            todoList.ToDoListFinishMax();
            todoList.ToDoListOutput();
        }
    }
}
