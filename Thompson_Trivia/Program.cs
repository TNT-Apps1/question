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
///Purpose:  Assignment #7 File IO Trivia Game (Main Class)
///Date:4-8-17
///*******************************
/// </summary>
namespace Thompson_Trivia
{
    class Program
    {
        static void Main(string[] args)
        {
            Info info = new Info();
            Controller controller = new Controller();

            info.Hello();
            controller.Play();
            info.Goodbye();


        }
    }
}
