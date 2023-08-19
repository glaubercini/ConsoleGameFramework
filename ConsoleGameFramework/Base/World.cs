using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameFramework.Base
{
    internal class World
    {
        private char[,] world;

        public int lines;

        public int columns;

        public World(int lines, int columns)
        {
            world = new char[lines, columns];
            this.lines = lines;
            this.columns = columns;
        }

        internal void Fill()
        {
            for (int l = 0; l < lines; l++)
            {
                for (int c = 0; c < columns; c++)
                {
                    // map outline
                    if (l is 0 && c is 0)
                    {
                        Draw(l, c, '╔');
                        continue;
                    }
                    if (c is 0 && l == lines - 1)
                    {
                        Draw(l, c, '╚');
                        continue;
                    }
                    if (c == columns - 1 && l is 0)
                    {
                        Draw(l, c, '╗');
                        continue;
                    }
                    if (c == columns - 1 && l == lines - 1)
                    {
                        Draw(l, c, '╝');
                        continue;
                    }
                    if (c is 0 || c == columns - 1)
                    {
                        Draw(l, c, '║');
                        continue;
                    }
                    if (l is 0 || l == lines - 1)
                    {
                        Draw(l, c, '═');
                        continue;
                    }

                    Draw(l, c, ' ');
                }
            }
        }

        public void Draw(int l, int c, string s)
        {
            s = s.Trim();
            s = s.Replace("\r", "");
            char[] chars = s.ToCharArray();
            int l_w = l;
            int c_w = c;

            foreach (var item in chars)
            {
                if (item == '\n')
                {
                    l_w++;
                    c_w = c;
                }
                else
                {
                    Draw(l_w, c_w, item);
                    c_w++;
                }
            }
        }

        public void Draw(int l, int c, char piece)
        {
            world[l, c] = piece;
        }

        public char At(int l, int c)
        {
            return world[l, c];
        }
    }
}
