using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
///*******************************
///Programmer:  Grant Thompson
/// ITDEV115 SPRING 2017 TUESDAY EVENING
/// Instuctor: Judith Ligocki
///Purpose:  Assignment #7 File IO Trivia Game (Info Class)
///Date:4-8-17
///*******************************
/// </summary>

namespace Thompson_Trivia
{
    class Info
    {



        /// <summary>
        /// Intro to Trivia game
        /// </summary>
        public void Hello()
        {
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Name:       Grant Thompson");
            Console.WriteLine("Course:     ITDEV - 115 evening");
            Console.WriteLine("Instructor: Judith Ligocki");
            Console.WriteLine("Assignment: Assignment #7 File IO Trivia Game");
            Console.WriteLine("Date:       4 / 8 / 2017");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Trivia:");
            Console.WriteLine("Try to answer as many State of Wisconsin questions as you can");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\tHit Enter when you are ready to start.");
            Console.ReadLine();

        }

        /// <summary>
        /// Final message for trivia game
        /// </summary>
        internal void Goodbye()
        {
            Console.Clear();
            Console.WriteLine("\n\nThanks for playing my Wisconsin trivia game.");
            Console.WriteLine();
            Console.WriteLine("\tHit Enter to exit.");
            Console.ReadLine();
        }
    }

}
