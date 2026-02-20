using System;

namespace COMP003A.Assignment6
{
    class Program
    { /* The programs purpose is to allow users to display books and
    select a book for update of completion */
        static void Main(string[] args)
        {
            //create the book objects
            Book book1 = new Book("Nineteen Eighty-Four", 340, false);
            Book book2 = new Book("Through The Looking Glass", 170, false);
            Book book3 = new Book("The Looking Glass Wars", 400, true);

            bool running = true; //checks if program is still running and continues loop if it is
            while (running)
            {
                Console.WriteLine();
                Console.WriteLine("1. Display All");
                Console.WriteLine("2. Update One Book");
                Console.WriteLine("3. Exit Program");
                Console.Write("Enter choice (1-3): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine();
                        Console.Write("Item 1: ");
                        book1.DisplayInfo();
                        Console.Write("Item 2: ");
                        book2.DisplayInfo();
                        Console.Write("Item 3: ");
                        book3.DisplayInfo();
                        break;
                    case "2":
                        Console.Write("Select item (1-3): ");

                        string selection = Console.ReadLine();

                        switch (selection)
                    {
                        case "1":
                            book1.MarkCompleted();
                            Console.WriteLine("Updated Item 1.");
                        break;
                        
                        case "2":
                            book2.MarkCompleted();
                            Console.WriteLine("Updated Item 2.");
                        break;
                        
                        case "3":
                            book3.MarkCompleted();
                            Console.WriteLine("Updated Item 3.");
                        break;
                    }
                        break;
                    case "3":
                        running = false;
                        Console.WriteLine("Program ended.");
                        break;
                }
                        
                        
            }
        }
    }
}

