using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeVolume : MonoBehaviour
{
    // Start is called before the first frame update
    public void increaseBGMVol(){
        AudioSource bgm = GameObject.Find("BGM").GetComponent<AudioSource>();
        bgm.volume += 0.1f;
    }

    public void decreaseBGMVol()
    {
        AudioSource bgm = GameObject.Find("BGM").GetComponent<AudioSource>();
        bgm.volume -= 0.1f;
    }

    public void increaseSoundEffVol()
    {
        AudioSource bgm = GameObject.Find("SoundEffect").GetComponent<AudioSource>();
        bgm.volume += 0.1f;
    }

    public void decreaseSoundEffVol()
    {
        AudioSource bgm = GameObject.Find("SoundEffect").GetComponent<AudioSource>();
        bgm.volume -= 0.1f;
    }

    public void timerStop(){
        Timer timer = GameObject.Find("Timer").GetComponent<Timer>();
        timer.goTimer = false;
     }

     public void timerStart(){
        Timer timer = GameObject.Find("Timer").GetComponent<Timer>();
        timer.goTimer = true;
        timer.secondsCount = 0;
     }
}
