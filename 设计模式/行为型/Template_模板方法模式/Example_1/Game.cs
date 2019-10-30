using System;
using System.Collections.Generic;
using System.Text;

namespace Template_模板方法模式.Example_1
{
    public abstract class Game
    {
        public abstract void Initialize();
        public abstract void StartPlay();
        public abstract void EndPlay();

        //模板
        public  void play()
        {

            //初始化游戏
            Initialize();

            //开始游戏
            StartPlay();

            //结束游戏
            EndPlay();
        }
    }
}
