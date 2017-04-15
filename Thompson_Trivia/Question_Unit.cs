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
///Purpose:  Assignment #7 File IO Trivia Game (model Class)
///Date:4-8-17
///*******************************
/// </summary>
namespace Thompson_Trivia
{
    class Question_Unit
    {

        private string question;
        private string answer;
        private string correctAnswer;
        private string explanation;

        /// <summary>
        /// setter / getter for explanation
        /// </summary>
        public string Explanation
        {
            get { return explanation; }
            set { explanation = value; }
        }

        /// <summary>
        /// setter / getter for correctAnswer
        /// </summary>
        public string CorrectAnswer
        {
            get { return correctAnswer; }
            set { correctAnswer = value; }
        }

        /// <summary>
        /// setter / getter for answer
        /// </summary>
        public string Answer
        {
            get { return answer; }
            set { answer = value; }
        }

        /// <summary>
        /// setter / getter for question
        /// </summary>
        public string Question
        {
            get { return question; }
            set { question = value; }
        }


        
    }
}
