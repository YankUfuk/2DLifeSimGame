using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{

    [HideInInspector]
    public float speed;
    private Rigidbody2D body;
    private SpriteRenderer sr;
    
    
    public void MovementOnX()
    {
        body.velocity = new Vector2(speed, body.velocity.y);
    }

    public void flipOnX(){
        sr.flipX = true;
    }

    public void getComponents()
    {
        body = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

}
