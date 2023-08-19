using ConsoleGameFramework.Base;
using ConsoleGameFramework.Scenarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameFramework
{
    internal class Game
    {
        public void Run()
        {
            Menu menu = new Menu();
            menu.Present();
        }
    }
}
