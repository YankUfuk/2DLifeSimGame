using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float moveForce = 4f;
    [SerializeField]
    private float jumpforce = 10f;
    private float movementX;
    public Rigidbody2D body;

    void Start()
    {
        
    }

    void Update()
    {
        PlayerMovementKeyboard();
    }

    public void PlayerMovementKeyboard()
    {
        movementX = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(movementX,0,0) * Time.deltaTime * moveForce;
    }
}
