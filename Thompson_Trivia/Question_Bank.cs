using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
///*******************************
///Programmer:  Grant Thompson
/// ITDEV115 SPRING 2017 TUESDAY EVENING
/// Instuctor: Judith Ligocki
///Purpose:  Assignment #7 File IO Trivia Game (Model builder Class)
///Date:4-8-17
///*******************************
/// </summary>

namespace Thompson_Trivia
{
    class Question_Bank
    {


        List<Question_Unit> questionList = new List<Question_Unit>();


        /// <summary>
        /// getter for questionList
        /// </summary>
        public List<Question_Unit> QuestionList
        {
            get { return questionList; }
        }


        public Question_Bank()
        {
            ReadQuestionFile("Questions.txt");
        }


        /// <summary>
        /// Read question file from users disk. If not found then create file
        /// </summary>
        /// <param name="path"></param>
        void ReadQuestionFile(string path)
        {

            String text = "";
            String[] questionStringArray;
            bool gotFile = true;

            Question_Unit question;

            do
            {

                try
                {
                    StreamReader reader = new StreamReader(path);

                    while (text != null)
                    {
                        question = new Question_Unit();
                        text = reader.ReadLine();
                        questionStringArray = text.Split('|');
                        

                        question.Question = questionStringArray[0];
                        question.Answer = questionStringArray[1];
                        question.CorrectAnswer = questionStringArray[2];
                        question.Explanation = questionStringArray[3];

                        questionList.Add(question);
 
                    }
                    reader.Close();
                    gotFile = true;



                }
                catch(FileNotFoundException)//file not found 
                {
                    WriteQuestionFile();//make file
                    gotFile = false;
                }
                catch (Exception)
                {

                    //throw;
                }






            } while (!gotFile);







        }


        /// <summary>
        /// Builds a file for program
        /// </summary>
        public void WriteQuestionFile()
        {
            QuestionBuilder qb = new QuestionBuilder();
            try
            {
                StreamWriter thewriter = new StreamWriter("Questions.txt");
                for (int i = 0; i < qb.Question.GetLength(0); i++)
                {
                    thewriter.WriteLine("{0}|{1}|{2}|{3}", qb.Question[i,0], qb.Question[i, 1], qb.Question[i, 2], qb.Question[i, 3]);
                }
                thewriter.Close();
                

            }
            catch (Exception ex)
            {
                
            }
            
        }





    }
}
