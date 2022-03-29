using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public Text timerText;
    public float secondsCount;
    private int minuteCount;
    private int hourCount;
    public bool goTimer = true;

    void Update(){
        if(goTimer){
            UpdateTimerUI();
        }
    }
 //call this on update
    public void UpdateTimerUI(){
     //set timer UI
        secondsCount += Time.deltaTime;
        timerText.text = hourCount +"h:"+ minuteCount +"m:"+(int)secondsCount + "s";
        if(secondsCount >= 60){
            minuteCount++;
            secondsCount = 0;
        }else if(minuteCount >= 60){
            hourCount++;
            minuteCount = 0;
        }    
     }
}
