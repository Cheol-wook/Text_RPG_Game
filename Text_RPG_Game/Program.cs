﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            while (true)
            {
                game.modechanger();
            }
        }
    }
}
