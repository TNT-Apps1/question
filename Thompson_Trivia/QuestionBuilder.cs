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
///Purpose:  Assignment #7 File IO Trivia Game (file builder data Class)
///Date:4-8-17
///*******************************
/// </summary>

namespace Thompson_Trivia
{
    /// <summary>
    /// Program data
    /// </summary>
    class QuestionBuilder
    {

        private string[,] question = { { "What state borders Wisconsin to the south?", "A) Indiana,B) Iowa,C) Illinois,D) Arizona", "c", "Illinois borders Wisconsin to the South." },
                                       { "Size-wise, where does Wisconsin rank among the 50 US states?","A) 5th,B) 18th,C) 23rd,D) 52nd", "c", "Wisconsin ranks 23rd in size."},
                                       { "What is the motto of Wisconsin?", "A) He who transplanted still sustains,B) Our liberties we prize and our rights we will maintain,C) Forward,D) BackWard", "c", "Forward is the Wisconsin state Moto."},
                                       { "What is the official state insect of Wisconsin?", "A) Ladybug,B) Monarch,C) Honeybee,D) Mosquito", "c", "The Honeybee is the wisconsin state insect." },
                                       { "In what city is the state capital of Wisconsin?", "A) Madison,B) Milwaukee,C) Green Bay,D) Racine", "a", "Madison is Wisconsins state capital." },
                                       { "What does the name Wisconsin represent in the Chippewa language?", "A) Clearing,B) Grassy place,C) One who puts to sleep,D) A great state on a great lake", "b", "Grassy place is the name translated from Chippewa language" },
                                       { "What is the highest point in Wisconsin?", "A) Timms Hill,B) Britton Hill,C) Magazine Mountain,D) Top floor of First Wisconsin Building", "a", "At 1,951 feet Timms Hill is the highest point in Wisonsin." },
                                       { "Which famous actor was born in Wisconsin?", "A) Katherine Hepburn,B) Spencer Tracy,C) Douglas Fairbanks,D) Ernest Borgnine", "b", "Spencer Tracy: April 5, 1900, Milwaukee, WI" },
                                       { "What do the two men on the Wisconsin state flag and the Great Seal represent?", "A) Labor on water and land,B) The wilderness and cultivated lands,C) Agriculture and mining,D) Science and Technology", "a", "Labor on water and land is reperesentd by the 2 men on the state flag."},
                                       { "The state's highest temperature, 114, was recorded in what town?", "A) Eau Claire,B) Fontana,C) Wisconsin Dells,D) Superior", "c", "Wisconsin Dells has the current record high for the state at 114*" } };

        public string[,] Question
        {
            get { return question; }
            
        }







    }
}
