using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakingMove : MonoBehaviour
{
    //declare what the code needs to use.
    //Turn it blue when you start, float a varible for speed (dec.) declare the sprite
    public Color TargetColor = Color.blue;
    public float _speed = 5.0f;
    public SpriteRenderer sprite;
    void Start()
    {
        sprite.color = TargetColor;
    }
    
    void Update()
    {
        //using unitys built in x and y axis movement 
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        
        Vector3 direction = new Vector3(horizontalInput, verticalInput, 0);
        // moving to that direction by multiplying the speed v time
        transform.Translate(direction * _speed * Time.deltaTime);
    }
}


//else is used opposed to the if statement.