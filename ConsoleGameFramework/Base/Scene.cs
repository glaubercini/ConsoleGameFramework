using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameFramework.Base
{
    internal abstract class Scene
    {
        private World World;

        private Camera Camera;

        private int Top = 1;

        public Scene()
        {
            World = new World(20, 80);
            World.Fill();
            Camera = new Camera();
        }

        public Scene Add(string text)
        {
            int tl = World.Draw(Top, 1, text);
            Top += tl;

            return this;
        }

        protected void Show()
        {
            Camera.Draw(World);
        }

        public string RequestUserOption()
        {
            Console.WriteLine("O que você faz?");

            string option = Console.ReadLine();

            return option;
        }

        public void Move(Scene scene)
        {
            scene.Show();

            string option = RequestUserOption();
            var s = scene.Options(option);

            scene.Move(s);
        }

        protected abstract Scene Options(string option);
    }
}
