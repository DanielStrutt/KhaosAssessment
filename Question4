using System;
using System.Globalization;

namespace Question4
{
    class Program
    {
        static void Main(string[] args)//Function which takes a string as a parameter and capitalises the first letter of each word. 
        {
            string sentence;
            string end;
 
            Console.WriteLine("Please write a sentence.");
            sentence = Console.ReadLine();
            Console.WriteLine("This is the sentence to be modified: " + sentence);//Sentence to be modified is written here

            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;//Changing the cultre name of the string to en-US

            Console.WriteLine("\"{0}\" to lowercase: {1}", sentence, myTI.ToLower(sentence));
            Console.WriteLine("\"{0}\" to uppercase: {1}", sentence, myTI.ToUpper(sentence));
            Console.WriteLine("\"{0}\" to titlecase: {1}", sentence, myTI.ToTitleCase(sentence));

            end = Console.ReadLine();
            Console.WriteLine("Program now ending...");
        }
    }
}
