using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //var r = new Random();
            //var favNumber = r.Next(1, 10);

            //Console.WriteLine("Guess my favorite number from 1 - 10");
            //var userInput = int.Parse(Console.ReadLine());

            //if (userInput < favNumber)
            //{
            //    Console.WriteLine($"{userInput} is too low");
            //}
            //else if(userInput > favNumber)
            //{
            //    Console.WriteLine($"{userInput} is too high");
            //}
            //else
            //{
            //    Console.WriteLine("You guessed it!");
            //}


            Console.WriteLine("What is your favorite subject?");
            string subject = Console.ReadLine();

            switch (subject)
            {
                case "Science":
                    Console.WriteLine("I hate Science!");
                    break;
                case "Math":
                    Console.WriteLine("I love Math!");
                    break;
                case "English":
                    Console.WriteLine("English was an easy class!");
                    break;
                case "History":
                    Console.WriteLine("My favorite subject in school!");
                    break;
                case "Spanish":
                    Console.WriteLine("I should've paid more attention!");
                    break;
                default:
                    Console.WriteLine("What did you learn in that?");
                    break;

            }
        }
    }
}

