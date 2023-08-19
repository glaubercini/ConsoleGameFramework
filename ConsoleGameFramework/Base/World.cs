using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameFramework.Base
{
    internal class World
    {
        private char[,] Map;

        public int Lines;

        public int Columns;

        public World(int lines, int columns)
        {
            Map = new char[lines, columns];
            Lines = lines;
            Columns = columns;
        }

        internal void Fill()
        {
            for (int l = 0; l < Lines; l++)
            {
                for (int c = 0; c < Columns; c++)
                {
                    // map outline
                    if (l is 0 && c is 0)
                    {
                        Draw(l, c, '╔');
                        continue;
                    }
                    if (c is 0 && l == Lines - 1)
                    {
                        Draw(l, c, '╚');
                        continue;
                    }
                    if (c == Columns - 1 && l is 0)
                    {
                        Draw(l, c, '╗');
                        continue;
                    }
                    if (c == Columns - 1 && l == Lines - 1)
                    {
                        Draw(l, c, '╝');
                        continue;
                    }
                    if (c is 0 || c == Columns - 1)
                    {
                        Draw(l, c, '║');
                        continue;
                    }
                    if (l is 0 || l == Lines - 1)
                    {
                        Draw(l, c, '═');
                        continue;
                    }

                    Draw(l, c, ' ');
                }
            }
        }

        public int Draw(int l, int c, string s)
        {
            s = s.Trim();
            s = s.Replace("\r", "");
            string[] words = s.Split('\n');
            int lt = l;
            int total_lines = 0;
            foreach (var word in words)
            {
                int ct = c;
                foreach (var letter in word)
                {
                    Draw(lt, ct, letter);
                    ct++;
                }
                lt++;
                total_lines++;
            }

            return total_lines;
        }

        public void Draw(int l, int c, char piece)
        {
            Map[l, c] = piece;
        }

        public char At(int l, int c)
        {
            return Map[l, c];
        }
    }
}
