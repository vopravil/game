using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeReload : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Speed()
    {
        GameObject.Find("player").GetComponent<fireMissile>().attackRate -= 0.2f;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
