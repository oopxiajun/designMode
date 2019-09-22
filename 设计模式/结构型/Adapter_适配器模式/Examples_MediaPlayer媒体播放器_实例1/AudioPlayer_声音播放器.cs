using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_适配器模式.Examples_MediaPlayer媒体播放器_实例1
{
    class AudioPlayer_声音播放器 : IMediaPlayer_媒体播放器接口
    {
        IMediaPlayer_媒体播放器接口 mediaAdapter;
        public void Play(string audioType, string fileName)
        {
            //播放 mp3 音乐文件的内置支持
            if (audioType.Equals("mp3"))
            {
                Console.WriteLine("Playing mp3 file. Name: " + fileName);
            }
            //mediaAdapter 提供了播放其他文件格式的支持
            else if (audioType.Equals("vlc")
               || audioType.Equals("mp4"))
            {
                mediaAdapter = new MediaAdapter_媒体适配器(audioType);
                mediaAdapter.Play(audioType, fileName);
            }
            else
            {
                Console.WriteLine("Invalid media. " +
                   audioType + " format not supported");
            }
        }
    }
}
