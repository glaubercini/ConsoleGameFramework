using ConsoleGameFramework.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameFramework.Scenarios
{
    internal class Menu : Scene
    {
        public Menu()
        {
            Add("1) Jogar")
                .Add("2) Sair");
        }

        public void Present()
        {
            Move(this);
        }

        protected override Scene Options(string option)
        {
            if (option == "1")
            {
                return new City();
            }

            return null;
        }
    }
}
