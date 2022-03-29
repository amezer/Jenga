using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    
    public bool fall = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        if(fall){
            Timer timer = GameObject.Find("Timer").GetComponent<Timer>();
            timer.goTimer = false;
            fall = false;
        }
        else
        {
            scoreText.text = "Score: " + score;
        }
    }
}
