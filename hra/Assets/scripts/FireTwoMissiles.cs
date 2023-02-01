using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireTwoMissiles : MonoBehaviour
{
    public Transform raketaTop;
    public Transform raketaBot;
    public float speed = 5f;
    
    public GameObject raketa;

    float nextAttackTime = 0f;
    public float attackRate = 0.5f;
    public AudioSource firingSound;
    // Start is called before the first frame update

    void Start()
    {

    }
    public void FireOnClkickTwoRockets()
    {
        if (Time.time >= nextAttackTime)
        {

            firingSound.Play();
            Instantiate(raketa, raketaTop.transform.position, raketaTop.rotation);
            Instantiate(raketa, raketaBot.transform.position, raketaBot.rotation);
            nextAttackTime = Time.time + attackRate;


        }
    }
    // Update is called once per frame
}