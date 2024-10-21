using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePlayerController : MonoBehaviour
{
    
    public Rigidbody2D RB;
    
    public float Speed = 5;

    void Start()
    {
      
    }

    void Update()
    {
       
        Vector2 vel = new Vector2(0,0);
        
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            vel.x = Speed;
        }
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            vel.x = -Speed;
        }
       
        if (Input.GetKey(KeyCode.UpArrow))
        {
            vel.y = Speed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            vel.y = -Speed;
        }
        
        RB.velocity = vel;
    }
}
