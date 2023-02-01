using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class detectCollision : MonoBehaviour
{
    public AudioSource sourceBum;
    public AudioSource sourceDie;
    public Animator animator;
    public static int score = 0;
   // public AudioSource bum;
    public AudioClip clipBum;
    public AudioClip clipDie;
    



    private void OnTriggerEnter2D(Collider2D collison)
    {
        
        /*if (collison.gameObject.tag == "tank" && gameObject.transform.position.x > 25)
        {
            Destroy(gameObject);
        }*/

        if (collison.gameObject.tag == "rocket")
        {

            score++;

            Destroy(gameObject, 0.6f);
            sourceBum.PlayOneShot(clipBum);
            animator.SetBool("isDead", true);


            BoxCollider2D[] myColliders = gameObject.GetComponents<BoxCollider2D>();
            foreach (BoxCollider2D bc in myColliders) bc.enabled = false;

            //GetComponent<BoxCollider2D>().enabled = false;
            //GetComponent<BoxCollider2D>().enabled = false;
            GetComponent<moveLeft>().enabled = false;
            
                           
            Debug.Log("hit");
            Destroy(collison.gameObject);


           
        }
        if (collison.gameObject.tag == "player")
        {
           
            sourceDie.PlayOneShot(clipDie);           
            BoxCollider2D[] myColliders = gameObject.GetComponents<BoxCollider2D>();
            foreach (BoxCollider2D bc in myColliders) bc.enabled = false;
            
        }

        
        
    }


    

}
