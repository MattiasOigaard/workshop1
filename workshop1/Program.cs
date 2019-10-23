using System;

namespace workshop1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = AskUserFor("first name");
            string lastName = AskUserFor("last name");
            int age = AskUserForNumber("age");

            Console.WriteLine($"your full name is {firstName} {lastName} and you are {age} ");

            double result = 7.4 * AskUserForNumber("gravity", true);

            Console.WriteLine("7.4 * your number is: " + result);

        }

        static string AskUserFor(string forWhat)
        {
            Console.Write($"Please Input: {forWhat}: ");
            return Console.ReadLine();
        }

        static int AskUserForNumber(string forWhat)
        {
            return int.Parse(AskUserFor(forWhat));
        }

        static double AskUserForNumber(string v1, bool v2)
        {
            return double.Parse(AskUserFor(v1));
        }

        static void SomeDateTime()
        {

            DateTime timeNow = DateTime.Now;

            Console.WriteLine(timeNow.Ticks);
            Console.WriteLine(timeNow.Date);
            Console.WriteLine(timeNow.Year);

            Console.WriteLine(timeNow.ToLongDateString());
            Console.WriteLine(timeNow.ToShortTimeString());
            Console.WriteLine(timeNow.ToString("MM-dd-yy"));
        }

        static void WorkingWithStrings()
        {
            Console.WriteLine($" 3 + 5 = { 3 + 5 }");
        }

    }


}
