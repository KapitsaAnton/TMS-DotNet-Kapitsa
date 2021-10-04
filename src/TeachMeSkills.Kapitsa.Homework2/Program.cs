using System;

namespace TeachMeSkills.Kapitsa.Homework2
{
    class Program
    {
        static void dateTest()
        {
            string userInputDate = Console.ReadLine();
            DateTime.TryParse(userInputDate, out DateTime date);
            // fallsDate - is a date of mistake value (01.01.0001)
            DateTime fallsDate = new DateTime(0001, 1, 1, 0, 0, 0);
            bool testOfDate1 = (date == fallsDate);

            switch (testOfDate1)
            {
                case true:
                    Console.WriteLine("Inserted value is incorrect.");
                    if (answewAnalyzer() == true)
                    {
                        Console.WriteLine("Insert a date.\nPlease, try to type your date in \"dd.MM.yyyy\" format");
                        dateTest();
                    }
                    else
                    {
                        Console.WriteLine("Program will skip this test.");
                    }
                    break;
                case false:
                    Console.WriteLine("Your date is: " + date.DayOfWeek);
                    if (answewAnalyzer() == true)
                    {
                        Console.WriteLine("Insert a date.\nPlease, try to type your date in \"dd.MM.yyyy\" format");
                        dateTest();
                    }
                    else
                    {
                        Console.WriteLine("Thank you for using this program!");
                    }
                    break;
            }
        }
        static bool answewAnalyzer()
        {
            bool answer;
            Console.WriteLine("If you want to make one more test type: Y\nOtherwise press any button.");
            string answerToContinue = Console.ReadLine();
            switch (answerToContinue)
            {
                case ("Y"):
                    answer = true;
                    break;
                case ("y"):
                    answer = true;
                    break;
                default:
                    answer = false;
                    break;
            }
            return answer;
        }

        static void Main()
        {
            // Hometask 2: day of week Handler
            Console.WriteLine("Hometask 2.\nInsert a date, please:");
            dateTest();
        }
    }
}
