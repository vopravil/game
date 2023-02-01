using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeProjectiles : MonoBehaviour
{
    public GameObject button;
   
   public void TwoRockets()
    {
        

        fireMissile.pomocna = 1;
        button.SetActive(false);
    }

   
}
