using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoretext;
    public GameObject panel;
    public GameObject button;
    int pomocna = 0;
    public int killCount = 0; 
   


    // Start is called before the first frame update
    void Start()
    {
        scoretext = GetComponent<TextMeshProUGUI>(); 
    }
    
    // Update is called once per frame
    void Update()
    {
      

        scoretext.text ="SCORE: " + detectCollision.score;
        if ( killCount + pomocna   < detectCollision.score )
        {
            killCount = detectCollision.score;
            Time.timeScale = 0;                    
            panel.SetActive(true);
            pomocna = killCount;

            if (outOfBorder.tankSurvive > 0)
            {
               
               button.SetActive(true);

            }
            else
            {
              
               button.SetActive(false);
            }

            GameObject.Find("Ovladani").SetActive(false);

        }
        
        
    }
}
