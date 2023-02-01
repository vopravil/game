using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveForward : MonoBehaviour
{
    // Start is called before the first frame update
    public float Speed = 5f;
    

    // Update is called once per frame
    void Update()
    {
       
        transform.Translate(Vector2.right * Speed * Time.deltaTime);
        if (transform.position.x > 20)
        {
            Destroy(gameObject);
        }
    }
    
}
