using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddLife : MonoBehaviour
{
    public GameObject[] lifeList;
    public GameObject button;
   
    // Start is called before the first frame update
    void Start()
    {
       
    }
    public void addLife()
    {
        lifeList[(3) - outOfBorder.tankSurvive].SetActive(true);

        //GameObject.Find("player").GetComponent<lives>().lifeCaount[2].SetActive(true); 
        outOfBorder.tankSurvive--;


    }
    private void Update()
    {
     
        


    }

   
}
    