using System;
using System.Collections.Generic;
using System.Text;

namespace Template_模板方法模式.Example_1
{
    public class Football : Game
    {
        public override void EndPlay()
        {
            Console.WriteLine("Football  Game Finished!");
        }

        public override void Initialize()
        {
            Console.WriteLine("Football  Game Initialized! Start playing.");
        }

        public override void StartPlay()
        {
            Console.WriteLine("Football  Game Started. Enjoy the game!");
        }
    }
}
