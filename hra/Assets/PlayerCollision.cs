using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Animator animator;
    public GameObject fireButton;

    // Update is called once per frame
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "tank")
        {
            animator.SetBool("getHit", true);
            fireButton.SetActive(false);
            GameObject.Find("player").GetComponent<playerMovement>().moveSpeed = 0;
            Invoke("WaitAndStop", 1.1f);
        }
    }
    void WaitAndStop()
    {
        animator.SetBool("getHit", false);
        fireButton.SetActive(true);
        GameObject.Find("player").GetComponent<playerMovement>().moveSpeed = 5;
    }
}
