using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_适配器模式.Examples_MediaPlayer媒体播放器_实例1
{
    public class AdapterPatternDemo
    {
        public static void test( )
        {
            AudioPlayer_声音播放器 audioPlayer = new AudioPlayer_声音播放器();

            audioPlayer.Play("mp3", "beyond the horizon.mp3");
            audioPlayer.Play("mp4", "alone.mp4");
            audioPlayer.Play("vlc", "far far away.vlc");
            audioPlayer.Play("avi", "mind me.avi");
        }
    }
}
