using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChangeSpeed : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Speed()
    {
        GameObject.Find("player").GetComponent<playerMovement>().moveSpeed += 2; 
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
