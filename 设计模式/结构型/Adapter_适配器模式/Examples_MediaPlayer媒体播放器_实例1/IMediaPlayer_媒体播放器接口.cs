using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_适配器模式.Examples_MediaPlayer媒体播放器_实例1
{
    public interface IMediaPlayer_媒体播放器接口
    {
         void Play(String audioType, String fileName);
    }
}
