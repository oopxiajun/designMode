using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_适配器模式.Examples_MediaPlayer媒体播放器_实例1
{
    public interface IAdvancedMediaPlayer_高级媒体播放接口
    {
          void PlayVlc(String fileName);
          void PlayMp4(String fileName);
    }
}
