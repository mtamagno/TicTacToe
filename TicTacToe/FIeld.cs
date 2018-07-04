using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{


    class FIeld
    {
        public char[,] playField =
            {
                { '1', '2', '3' },
                { '4', '5', '6' },
                { '7', '8', '9' }
            };

        public void createField()
        {
            Console.WriteLine("         |        |       |");
            Console.WriteLine("    {0}    |   {1}    |   {2}   !",playField[0,0], playField[0, 1], playField[0, 2]);
            Console.WriteLine("         |        |       |");
            Console.WriteLine("_________|________|_______|");
            Console.WriteLine("         |        |       |");
            Console.WriteLine("    {0}    |   {1}    |   {2}   !", playField[1, 0], playField[1, 1], playField[1, 2]);
            Console.WriteLine("         |        |       |");
            Console.WriteLine("_________|________|_______|");
            Console.WriteLine("         |        |       |");
            Console.WriteLine("    {0}    |   {1}    |   {2}   !", playField[2, 0], playField[2, 1], playField[2, 2]);
            Console.WriteLine("         |        |       |");
        }
    }


}
