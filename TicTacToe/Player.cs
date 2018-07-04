using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Player
    {
        public char simbolInput;
        public bool active;

        public string Name { get; }

        public Player(string name, char simbolInput)
        {
            this.Name = name;
            this.simbolInput = simbolInput;
        }
    }
}
