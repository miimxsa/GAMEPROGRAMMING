using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ENEMYMOVES : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public float distance;
    public int Score = 0;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     distance = Vector2.Distance(transform.position, player.transform.position);
     Vector2 direction = player.transform.position - transform.position;
     direction.Normalize();
     float angle = Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg;


     transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
     transform.rotation = Quaternion.Euler(Vector3.forward * angle);
   
    }
    
            // find a way the hazards dont overlap one another
            // find a way they cannot go through the wall like the player 
            // find a way to code in different currency levels 
            // find a way to lose points rather than a game over/ perhaps a 3x life 
            // find a better way to set up the wall collider so it isnt randomly just staying there
}
