using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


/// <summary>
///*******************************
///Programmer:  Grant Thompson
/// ITDEV115 SPRING 2017 TUESDAY EVENING
/// Instuctor: Judith Ligocki
///Purpose:  Assignment #7 File IO Trivia Game (Controller)
///Date:4-8-17
///*******************************
/// </summary>
namespace Thompson_Trivia
{
    class Controller
    {

        Question_Bank questionBank;

       public Controller()
        {
            questionBank = new Question_Bank();
        }

        public void Play()
        {

            string loopController = "y";

            do
            {
                String theirAnswer = "";
                int correctlyAnswered = 0;
                int questionNumber = 0;
                double score = 0;

                for (int i = 0; i < questionBank.QuestionList.Count; i++)
                {

                    char[] tempCharArray = questionBank.QuestionList[i].Question.ToCharArray();
                    string[] possibleAnswers = questionBank.QuestionList[i].Answer.Split(',');

                    Console.Clear();

                    if (questionNumber != 0)
                        Console.WriteLine("\nCorrectly answered {0}/{1}\n\n", correctlyAnswered, questionNumber);//score tracker
                    else
                        Console.WriteLine("\n\n\n");

                    questionNumber++;

                    Console.Write("\t" + (i + 1) + ") ");
                    for (int j = 0; j < tempCharArray.Length; j++)
                    {
                        Console.Write(tempCharArray[j]);//display question
                        Thread.Sleep(40);
                    }
                    Console.WriteLine();
                    for (int j = 0; j < possibleAnswers.Length; j++)
                    {
                        Console.WriteLine("\t\t" + possibleAnswers[j]);//display possible answers
                    }

                    Console.WriteLine();
                    Console.Write("Select an answer (A-D) ==> ");
                    //Console.Write("\t==>");
                    theirAnswer = Console.ReadLine();//get players answer

                    if (theirAnswer.ToLower() == questionBank.QuestionList[i].CorrectAnswer)//display for correct answer
                    {
                        Console.WriteLine("\n\n\t'{0}' is correct:", theirAnswer.ToUpper());
                        correctlyAnswered++;
                    }
                    else
                    {
                        Console.WriteLine("\n\n\t'{0}' is incorrect:", theirAnswer.ToUpper());//display for incorrect answer
                    }

                    Console.WriteLine("\t" + questionBank.QuestionList[i].Explanation);//display explantion
                    Console.WriteLine("\nPress enter to continue");
                    Console.ReadLine();


                }

                Console.Clear();

                score = ((double) correctlyAnswered / questionNumber) * 100;//display final score

                Console.WriteLine("\n\n\nYou scored {0:0.00}%\n", score);
                Console.WriteLine("Would you like to try again? Y:N");//play again loop ?
                loopController= Console.ReadLine().ToLower();


            } while (loopController == "y");

            



        }

    }
}
