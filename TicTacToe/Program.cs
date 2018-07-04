using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            FIeld field = new FIeld();
            Player Player1 = new Player("Marco", 'x');
            Player Player2 = new Player("Francesca", 'o');
            int input;
            Player[] Players = { Player1 , Player2 };

            bool isOk = true;
            bool correctInput = false;

            field.createField();

            do
            {
                correctInput = false;

                if (Players[0].active == true)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Let's do this {0}!!", Players[0].Name);
                    Console.WriteLine("What field do u choose??!");
                    Players[0].active = false;
                    Players[1].active = true;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("All right {0} is your turn!",Players[1].Name);
                    Console.WriteLine("What field do u choose??!");
                    Players[1].active = false;
                    Players[0].active = true;
                }

                do
                {
                    input = 0;
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                       
                    }
                   

                    switch (input)
                    {
                        case 1: correctInput = field.playField[0, 0] == '1' ? true : false; if (correctInput == true) field.playField[0, 0] = Players[0].active == true ? (Players[0].simbolInput) : (Players[1].simbolInput); if (correctInput == false) Console.WriteLine("That field is already taken!"); break;
                        case 2: correctInput = field.playField[0, 1] == '2' ? true : false; if (correctInput == true) field.playField[0, 1] = Players[0].active == true ? (Players[0].simbolInput) : (Players[1].simbolInput); if (correctInput == false) Console.WriteLine("That field is already taken!"); break;
                        case 3: correctInput = field.playField[0, 2] == '3' ? true : false; if (correctInput == true) field.playField[0, 2] = Players[0].active == true ? (Players[0].simbolInput) : (Players[1].simbolInput); if (correctInput == false) Console.WriteLine("That field is already taken!"); break;
                        case 4: correctInput = field.playField[1, 0] == '4' ? true : false; if (correctInput == true) field.playField[1, 0] = Players[0].active == true ? (Players[0].simbolInput) : (Players[1].simbolInput); if (correctInput == false) Console.WriteLine("That field is already taken!"); break;
                        case 5: correctInput = field.playField[1, 1] == '5' ? true : false; if (correctInput == true) field.playField[1, 1] = Players[0].active == true ? (Players[0].simbolInput) : (Players[1].simbolInput); if (correctInput == false) Console.WriteLine("That field is already taken!"); break;
                        case 6: correctInput = field.playField[1, 2] == '6' ? true : false; if (correctInput == true) field.playField[1, 2] = Players[0].active == true ? (Players[0].simbolInput) : (Players[1].simbolInput); if (correctInput == false) Console.WriteLine("That field is already taken!"); break;
                        case 7: correctInput = field.playField[2, 0] == '7' ? true : false; if (correctInput == true) field.playField[2, 0] = Players[0].active == true ? (Players[0].simbolInput) : (Players[1].simbolInput); if (correctInput == false) Console.WriteLine("That field is already taken!"); break;
                        case 8: correctInput = field.playField[2, 1] == '8' ? true : false; if (correctInput == true) field.playField[2, 1] = Players[0].active == true ? (Players[0].simbolInput) : (Players[1].simbolInput); if (correctInput == false) Console.WriteLine("That field is already taken!"); break;
                        case 9: correctInput = field.playField[2, 2] == '9' ? true : false; if (correctInput == true) field.playField[2, 2] = Players[0].active == true ? (Players[0].simbolInput) : (Players[1].simbolInput); if (correctInput == false) Console.WriteLine("That field is already taken!"); break;

                        default: correctInput = false; Console.WriteLine("Enter a valid input!!"); break;
                    }
                } while (!correctInput);

                Console.Clear();
                field.createField();

            } while (isOk);


            Console.ReadLine();
        }
    }
}
