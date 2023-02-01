using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outOfBorder : MonoBehaviour
{
    // Start is called before the first frame update
    public static int tankSurvive = 0;
   

    // Update is called once per frame
   
    void Update()
    {
       
        if (transform.position.x < -15)
        {
            tankSurvive++;
            Destroy(gameObject);
            Debug.Log(tankSurvive);
           // Destroy(gameObject);
        }
    }
}
