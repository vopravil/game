using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;
    [SerializeField]private DynamicJoystick joystick;
    
  

    // Update is called once per frame
    void Update()
    {
       
            movement.y = joystick.Vertical/*Input.GetAxis("Vertical")*/;
        


    }
     void FixedUpdate()
    {
    if (Input.touchCount > 0)
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        }
    }
}
