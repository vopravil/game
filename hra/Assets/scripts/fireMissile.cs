using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireMissile : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 5f;
    public Transform poloha;
    public GameObject raketa;

    public Transform raketaTop;
    public Transform raketaBot;
    float nextAttackTime = 0f;
    public float attackRate = 1f;
    public AudioSource firingSound;
   public static int pomocna = 0;
    void Start()
    {
        
    }

    public void FireOnClick()
    {
        if (Time.time >= nextAttackTime && pomocna == 0)
        {

            firingSound.Play();
                Instantiate(raketa, poloha.transform.position, poloha.rotation);
                nextAttackTime = Time.time + attackRate;
            

        }
    }


    public void FireOnClkickTwoRockets()
    {
        if (Time.time >= nextAttackTime && pomocna == 1)
        {

            firingSound.Play();
            Instantiate(raketa, raketaTop.transform.position, raketaTop.rotation);
            Instantiate(raketa, raketaBot.transform.position, raketaBot.rotation);
            nextAttackTime = Time.time + attackRate;


        }
    }


    // Update is called once per frame
    /* void Update()
     {
         if (Time.time >= nextAttackTime)
         {
             if (Input.GetKeyDown(KeyCode.Space))
             {

                 Instantiate(raketa, poloha.transform.position, poloha.rotation);
                 nextAttackTime = Time.time + attackRate;
             }

         }

     }*/
}
