using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_适配器模式.Examples_MediaPlayer媒体播放器_实例1
{
    class MediaAdapter_媒体适配器 : IMediaPlayer_媒体播放器接口
    {
        IAdvancedMediaPlayer_高级媒体播放接口 advancedMusicPlayer;

        public MediaAdapter_媒体适配器(String audioType)
        {
            if (audioType.Equals("vlc"))
            {
                advancedMusicPlayer = new VlcPlayer();
            }
            else if (audioType.Equals("mp4"))
            {
                advancedMusicPlayer = new Mp4Player();
            }
        }

        public void Play(string audioType, string fileName)
        {
            if (audioType.Equals("vlc"))
            {
                advancedMusicPlayer.PlayVlc(fileName);
            }
            else if (audioType.Equals("mp4"))
            {
                advancedMusicPlayer.PlayMp4(fileName);
            }
        }
    }
}
