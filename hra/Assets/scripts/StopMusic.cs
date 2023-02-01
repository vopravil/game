using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StopMusic : MonoBehaviour
{
    public Sprite[] iconArray;
    public GameObject button;
    float musicValue;
    int pomocna = 0;
     void Start()
    {
        musicValue = AudioListener.volume;
    }

    public void stopOrPlayMusic()
    {
        if (pomocna == 0)
        {
            button.GetComponent<Image>().sprite = iconArray[1];
            AudioListener.volume = 0;
            
            pomocna++;
            
        }
        else if (pomocna == 1)
        {
            button.GetComponent<Image>().sprite = iconArray[0];
            AudioListener.volume = musicValue;
            pomocna--;
        }
       
    }
}
