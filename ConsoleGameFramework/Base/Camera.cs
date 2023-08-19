using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameFramework.Base
{
    internal class Camera
    {
        public void Draw(World world)
        {
            for (int j = 0; j < world.Lines; j++)
            {
                for (int i = 0; i < world.Columns; i++)
                {
                    Console.Write(world.At(j, i));
                }

                Console.WriteLine();
            }
        }
    }
}
