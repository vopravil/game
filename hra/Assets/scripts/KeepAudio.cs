using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepAudio : MonoBehaviour
{
    public static KeepAudio instance;
   

    private void Awake()
    {
        AudioListener.volume = PlayerPrefs.GetFloat("musicVolume");
        if (PlayerPrefs.HasKey("musicVolume") == false)
        {
            AudioListener.volume = 0;
        }
        DontDestroyOnLoad(this.gameObject);
        if ( instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
