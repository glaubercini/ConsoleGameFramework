using ConsoleGameFramework.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameFramework.Scenarios
{
    internal class City : Scene
    {
        public City()
        {
            Add("Você está na cidade, ela é fria como o gelo.");
            Add("-----------------");
            Add("---            --");
            Add("---            --");
            Add("---     ___    --");
            Add("---    |   |   --");
        }

        protected override Scene Options(string options)
        {
            return new City();
        }
    }
}
