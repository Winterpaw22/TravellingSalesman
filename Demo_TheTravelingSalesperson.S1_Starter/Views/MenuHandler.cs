using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_TheTravelingSalesperson
{
    class MenuHandler
    {
        /// <summary>
        /// This is the YES or NO version and will return a bool for ease of use
        /// Working
        /// </summary>
        /// <param name="startPosY">The starting height, (Counting down so the top left is 0 and next one down is 1)</param>
        /// <param name="startPosX">The starting position counting right starting with 0</param>
        /// <param name="question">Enter the question you desire to ask</param>
        public static bool ChoiceSelectionCursor(int startPosY, int startPosX, string question)
        {
            ConsoleKeyInfo keyPress;
            int tOb = startPosY + 1;
            int tObLast = tOb;
            int tObPos = startPosX + 1;
            int answerPos = startPosX + 5;
            int action = 1;
            int optionUno = startPosY + 1;
            int optionDos = startPosY + 2;


            bool yn = true;
            bool optionSelected = false;
            Console.CursorVisible = false;

            Console.SetCursorPosition(startPosX, startPosY);
            Console.Write(question);

            Console.SetCursorPosition(startPosX + 4, optionUno);
            Console.Write("Yes");

            Console.SetCursorPosition(startPosX + 4, optionDos);
            Console.Write("No");

            Console.SetCursorPosition(startPosX, optionDos + 2);
            Console.Write("Please press enter when you have the cursor over the option you wish to select");


            Console.SetCursorPosition(tObPos, tOb);
            Console.Write("->");
            while (!optionSelected)
            {
                keyPress = Console.ReadKey();

                if (keyPress.Key == ConsoleKey.UpArrow)
                {

                    if (action == 2)
                    {
                        action--;
                        tOb--;
                    }
                    Console.SetCursorPosition(tObPos, tObLast);
                    Console.Write("  ");
                    Console.SetCursorPosition(tObPos, tOb);
                    Console.Write("->");
                    tObLast = tOb;
                }
                if (keyPress.Key == ConsoleKey.DownArrow)
                {
                    if (action == 1)
                    {
                        action++;
                        tOb++;
                    }


                    Console.SetCursorPosition(tObPos, tObLast);
                    Console.Write("  ");
                    Console.SetCursorPosition(tObPos, tOb);
                    Console.Write("->");
                    tObLast = tOb;
                }
                if (keyPress.Key == ConsoleKey.Enter)
                {
                    optionSelected = true;
                }
                Console.SetCursorPosition(tObPos, tObLast);

            }
            Console.Clear();
            return yn;
        }


        /// <summary>
        /// This is the YES or NO version and will return a bool for ease of use
        /// Working
        /// </summary>
        /// <param name="startPosY">The starting height, (Counting down so the top left is 0 and next one down is 1)</param>
        /// <param name="startPosX">The starting position counting right starting with 0</param>
        /// <param name="question">Enter the question you desire to ask</param>
        public static bool ChoiceSelectionCursor(int startPosY, int startPosX, string question, string answer1, string answer2)
        {
            ConsoleKeyInfo keyPress;
            int tOb = startPosY + 1;
            int tObLast = tOb;
            int tObPos = startPosX + 1;
            int answerPos = startPosX + 5;
            int action = 1;
            int optionUno = startPosY + 1;
            int optionDos = startPosY + 2;


            bool yn = true;
            bool optionSelected = false;
            Console.CursorVisible = false;

            Console.SetCursorPosition(startPosX, startPosY);
            Console.Write(question);

            Console.SetCursorPosition(startPosX + 4, optionUno);
            Console.Write(answer1);

            Console.SetCursorPosition(startPosX + 4, optionDos);
            Console.Write(answer2);

            Console.SetCursorPosition(startPosX, optionDos + 2);
            Console.Write("Please press enter when you have the cursor over the option you wish to select");


            Console.SetCursorPosition(tObPos, tOb);
            Console.Write("->");
            while (!optionSelected)
            {
                keyPress = Console.ReadKey();

                if (keyPress.Key == ConsoleKey.UpArrow)
                {

                    if (action == 2)
                    {
                        action--;
                        tOb--;
                    }
                    Console.SetCursorPosition(tObPos, tObLast);
                    Console.Write("  ");
                    Console.SetCursorPosition(tObPos, tOb);
                    Console.Write("->");
                    tObLast = tOb;
                }
                if (keyPress.Key == ConsoleKey.DownArrow)
                {
                    if (action == 1)
                    {
                        action++;
                        tOb++;
                    }


                    Console.SetCursorPosition(tObPos, tObLast);
                    Console.Write("  ");
                    Console.SetCursorPosition(tObPos, tOb);
                    Console.Write("->");
                    tObLast = tOb;
                }
                if (keyPress.Key == ConsoleKey.Enter)
                {
                    optionSelected = true;
                }
                Console.SetCursorPosition(tObPos, tObLast);

            }
            Console.Clear();
            return yn;
        }




        /// <summary>
        /// This is the YES or NO version and will return a bool for ease of use
        /// 
        /// </summary>
        /// <param name="startPosY">The starting height, (Counting down so the top left is 0 and next one down is 1)</param>
        /// <param name="startPosX">The starting position counting right starting with 0</param>
        /// <param name="question">Enter the question you desire to ask</param>
        /// <param name="answer1">Enter the First Answer to the question</param>
        /// <param name="answer2">Enter the Second Answer to the question</param>
        /// <param name="answer3">Enter the Third Answer to the question</param>
        public static int ChoiceSelectionCursor(int startPosY, int startPosX, string question, string answer1, string answer2, string answer3)
        {
            ConsoleKeyInfo keyPress;
            int tOb = startPosY + 2;
            int tObLast = tOb;
            int tObPos = startPosX + 1;
            int answerPos = startPosX + 5;
            int action = 1;


            bool optionSelected = false;
            Console.CursorVisible = false;

            Console.SetCursorPosition(startPosX, startPosY + 1);
            Console.Write(question);

            Console.SetCursorPosition(startPosX + 4, startPosY + 2);
            Console.Write(answer1);

            Console.SetCursorPosition(startPosX + 4, startPosY + 3);
            Console.Write(answer2);

            Console.SetCursorPosition(startPosX + 4, startPosY + 4);
            Console.Write(answer3);

            Console.SetCursorPosition(startPosX, startPosY);
            Console.Write("Please press enter when you have the cursor over the option you wish to select");


            Console.SetCursorPosition(tObPos, tOb);
            Console.Write("->");
            while (!optionSelected)
            {
                keyPress = Console.ReadKey();

                if (keyPress.Key == ConsoleKey.UpArrow)
                {

                    if (action > 1)
                    {
                        action--;
                        tOb--;
                    }
                    Console.SetCursorPosition(tObPos, tObLast);
                    Console.Write("  ");
                    Console.SetCursorPosition(tObPos, tOb);
                    Console.Write("->");
                    tObLast = tOb;
                }
                if (keyPress.Key == ConsoleKey.DownArrow)
                {
                    if (action < 3)
                    {
                        action++;
                        tOb++;
                    }


                    Console.SetCursorPosition(tObPos, tObLast);
                    Console.Write("  ");
                    Console.SetCursorPosition(tObPos, tOb);
                    Console.Write("->");
                    tObLast = tOb;
                }
                if (keyPress.Key == ConsoleKey.Enter)
                {
                    optionSelected = true;
                }
                Console.SetCursorPosition(tObPos, tObLast);

            }
            Console.Clear();
            return action;
        }


        /// <summary>
        /// This is the YES or NO version and will return a bool for ease of use
        /// 
        /// </summary>
        /// <param name="startPosY">The starting height, (Counting down so the top left is 0 and next one down is 1)</param>
        /// <param name="startPosX">The starting position counting right starting with 0</param>
        /// <param name="question">Enter the question you desire to ask</param>
        /// <param name="answer1">Enter the First Answer to the question</param>
        /// <param name="answer2">Enter the Second Answer to the question</param>
        /// <param name="answer3">Enter the Third Answer to the question</param>
        public static int ChoiceSelectionCursor(int startPosY, int startPosX, string question, string answer1, string answer2, string answer3, string answer4)
        {
            ConsoleKeyInfo keyPress;
            int tOb = startPosY + 2;
            int tObLast = tOb;
            int tObPos = startPosX + 1;
            int answerPos = startPosX + 5;
            int action = 1;


            bool optionSelected = false;
            Console.CursorVisible = false;

            Console.SetCursorPosition(startPosX, startPosY + 1);
            Console.Write(question);

            Console.SetCursorPosition(startPosX + 4, startPosY + 2);
            Console.Write(answer1);

            Console.SetCursorPosition(startPosX + 4, startPosY + 3);
            Console.Write(answer2);

            Console.SetCursorPosition(startPosX + 4, startPosY + 4);
            Console.Write(answer3);

            Console.SetCursorPosition(startPosX + 5, startPosY + 5);
            Console.Write(answer4);

            Console.SetCursorPosition(startPosX, startPosY);
            Console.Write("Please press enter when you have the cursor over the option you wish to select");


            Console.SetCursorPosition(tObPos, tOb);
            Console.Write("->");
            while (!optionSelected)
            {
                keyPress = Console.ReadKey();

                if (keyPress.Key == ConsoleKey.UpArrow)
                {

                    if (action > 1)
                    {
                        action--;
                        tOb--;
                    }
                    Console.SetCursorPosition(tObPos, tObLast);
                    Console.Write("  ");
                    Console.SetCursorPosition(tObPos, tOb);
                    Console.Write("->");
                    tObLast = tOb;
                }
                if (keyPress.Key == ConsoleKey.DownArrow)
                {
                    if (action < 3)
                    {
                        action++;
                        tOb++;
                    }


                    Console.SetCursorPosition(tObPos, tObLast);
                    Console.Write("  ");
                    Console.SetCursorPosition(tObPos, tOb);
                    Console.Write("->");
                    tObLast = tOb;
                }
                if (keyPress.Key == ConsoleKey.Enter)
                {
                    optionSelected = true;
                }
                Console.SetCursorPosition(tObPos, tObLast);

            }
            Console.Clear();
            return action;
        }



    }
}
