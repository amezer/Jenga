using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockDetect : MonoBehaviour
{
    private bool fall = false;
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
}
