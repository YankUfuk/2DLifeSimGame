using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{

    [HideInInspector]
    public float speed;
    
    private Rigidbody2D body;
    
    
    
   public void Awake()
    {

        body = GetComponent<Rigidbody2D>();
        speed = 1;

    }
    public void FixedUpdate()
    {
        body.velocity = new Vector2(-speed, body.velocity.y);
        
    }
    

   
        
    

}
