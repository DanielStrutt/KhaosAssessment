using System;

namespace NameFormat
{
    class Program
    {
        //This function accepts three string parameters (Title, First name, Last name) to print an individuals full name.
        static void Main(string[] args)
        {
            string title;
            string forename;
            string surname;
            string end;
            
            Console.WriteLine("Please Enter Your Title.");
            title = Console.ReadLine();
            Console.WriteLine("Please Enter Your Forename.");
            forename = Console.ReadLine();
            Console.WriteLine("Please Enter Your Surname.");
            surname = Console.ReadLine();
            Console.WriteLine("Ah I see that your name is {0} {1} {2}. Press any key to exit.",title,forename,surname);
            end = Console.ReadLine();
            Console.WriteLine("Program now ending.");
        }
    }
}
