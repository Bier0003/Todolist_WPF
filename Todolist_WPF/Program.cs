using System;
using System.Collections.Generic;
namespace Todolist_WPF
{
    public class Program
    {
        public static DB_Operation operation = new DB_Operation();
        private static List<Todo> lists = new List<Todo>();
        static void Main(string[] args)
        {
           
            string todoText = "";
            //lists = FileManager.ReadFile();

            bool istrue = true;

            while (istrue)
            {
                
                Console.WriteLine("\x2505" + "\x2505" + "\x2505" + "\x2505" + "\x2505" + "\x2505" + "\x2505" + "\x2505" + "\x2505" + "\x2505" + "\x2505" + "\x2505\n");
                Console.WriteLine("##### To-do-List Apps #####\n");
                Console.WriteLine(" Main Menu :");
                Console.WriteLine("1) Add Lists");
                Console.WriteLine("2) Remove list");
                Console.WriteLine("3) View list");
                Console.WriteLine("4) Mark as Done");
                Console.WriteLine("5) Edit List");
                Console.WriteLine("E)Exit.\n");
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                Console.WriteLine("\x2505" + "\x2505" + "\x2505" + "\x2505" + "\x2505" + "\x2505" + "\x2505" + "\x2505" + "\x2505" + "\x2505" + "\x2505" + "\x2505");



                string userInput = Console.ReadLine();


                switch (userInput)
                {
                    case "1":

                        operation.GetList();
                        Console.WriteLine("Add to List:\n");

                        Todo todo = new Todo();

                        Console.WriteLine("Write new text: \n");
                        todo.TodoText = Console.ReadLine();

                        operation.InsertList(todo);

                        Console.WriteLine("##Operation ADD LIST Completed!##");
                        operation.GetList();

                        // Todo biggestId = lists.OrderByDescending(i => i.id).First();
                        //var todo = new Todo { TodoText = Add, id = biggestId.id + 1, Checked = false };
                        //lists.Add(todo);

                        operation.GetList();
                        // ShowList(lists);
                        break;

                    case "2":
                        //ShowList(lists);
                        operation.GetList();

                        Console.Write("Choose Text to Delete:\n");
                        Todo ID = new Todo();
                        ID.id = Convert.ToInt32(Console.ReadLine());

                        operation.DeleteItem(ID);



                        Console.WriteLine("##Operation Completed!##");
                        operation.GetList();
                        // ShowList(lists);
                        break;

                    case "3":

                        Console.WriteLine("** list-to-do **\n");
                        operation.GetList();
                        //ShowList(lists);


                        break;

                    case "4":
                        operation.GetList();


                        Console.WriteLine("Choose list as finish:\n");
                        // ShowList(lists);
                        bool checkBox = false;

                        Todo Id = new Todo();
                        Id.id = Convert.ToInt32(Console.ReadLine());

                        // operation.MarkList(Id);

                        Console.WriteLine("##Operation MARK LIST Completed!##");
                        operation.GetList();
                        break;

                    case "5":

                        operation.GetList();

                        Console.WriteLine("Edit List:\n");
                        Todo Text2 = new Todo();

                        Console.Write("Id: ");
                        Text2.id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("ToDo Text: ");
                        Text2.TodoText = Console.ReadLine();

                        operation.EditItem(Text2);

                        Console.WriteLine("##Operation EDIT Completed!##");
                        operation.GetList();
                        break;
                    case "E":
                        Environment.Exit(0);

                        break;

                    default:
                        istrue = false;
                        break;
                }

                //operation.InsertList(lists);
                //FileManager.Save(lists);

                bool isChecked = false;


            }
        }
    }
}
