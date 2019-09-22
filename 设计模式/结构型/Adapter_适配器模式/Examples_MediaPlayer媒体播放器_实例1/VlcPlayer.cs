using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_适配器模式.Examples_MediaPlayer媒体播放器_实例1
{
    class VlcPlayer : IAdvancedMediaPlayer_高级媒体播放接口
    {
        public void PlayMp4(string fileName)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("暂不支持PlayMp4");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void PlayVlc(string fileName)
        {
           Console.WriteLine("Playing vlc file. Name: " + fileName);
        }
    }
}
