using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScoreUpdate : MonoBehaviour
{

    public TextMeshProUGUI highScoretext;
    // Start is called before the first frame update
    void Start()
    {
        highScoretext.text = "Hightscore: " + PlayerPrefs.GetInt("HighScore").ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
