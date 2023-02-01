using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class audioChanger : MonoBehaviour

{
    [SerializeField] Slider volumeSlider;
    
    // Start is called before the first frame update
    void Awake()
    {
      
        
        if (PlayerPrefs.HasKey("musicVolume")== false)
        {
            PlayerPrefs.SetFloat("musicVolume", 0);
            Load();
        }
        else
        {
            Load();
            
        }
    }
    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        
        Save();
    }


    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }
    private void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
    }

   
}
