using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{

    [HideInInspector]
    public float speed;
    private Rigidbody2D body;
    private SpriteRenderer sr;
    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        sr.flipX = true;
        speed = 2f;
    }

    
    void FixedUpdate()
    {
        body.velocity = new Vector2(speed, body.velocity.y);
    }
}
