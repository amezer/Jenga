using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class GameManager : MonoBehaviour
{
    public Slider volumeSlider;
    // Start is called before the first frame update
    void Start()
    {
        //AudioListener.volume = 0.3f;
    }

    // Update is called once per frame
    void Update(){
        AudioListener.volume = volumeSlider.value;
    }
}
