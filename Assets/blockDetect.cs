using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockDetect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //isFall();
    }
    
    public void addScore(){
        GameManager gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        gameManager.score += 1;
    }
    
    public void isFall(){
        GameManager gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        Debug.Log(transform.position.y);
        if(transform.position.y < -0.45f){
            gameManager.fall = true;
        }
    }
}
