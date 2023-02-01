using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        /*if (outOfBorder.tankSurvive > 0)
        {
            GameObject.Find("liveButton").gameObject.SetActive(true);
            // button.SetActive(true);
        }*/
        if (outOfBorder.tankSurvive == 0)
        {
            GameObject.Find("liveButton").gameObject.SetActive(false);
            //button.SetActive(false);
        }
        else
        {
          //  button.SetActive(true);
            GameObject.Find("liveButton").gameObject.SetActive(true);

        }
    }
}
