using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
* 负责音频逻辑
*/
public interface IAudioService{
    //播放音频
    void play();
    //停止播放
    void stop();
}
