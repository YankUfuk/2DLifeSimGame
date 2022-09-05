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

    private SpriteRenderer sr;
    private Animator anim;
    private string WALK_ANIMATION = "Walk";
    private bool isGrounded = true;
    private string GROUND_TAG = "Ground";

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        
        
    }

    void Update()
    {
        PlayerMovementKeyboard();
        Animation();
    }

    void FixedUpdate()
    {
       PlayerJump();
    }

    public void PlayerMovementKeyboard()
    {
        movementX = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(movementX,0,0) * Time.deltaTime * moveForce;
    }

    public void PlayerJump()
    {
        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            isGrounded = false;
            body.AddForce(new Vector2(0f, jumpforce), ForceMode2D.Impulse);
        }
    }


    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag(GROUND_TAG)){
        isGrounded = true;
        }
 
    }
    public void Animation()
    {
        if(movementX > 0)
        {

            anim.SetBool(WALK_ANIMATION, true);
            sr.flipX = false;

        }else if(movementX < 0){

            anim.SetBool(WALK_ANIMATION, true);
            sr.flipX = true;

        }else{

            anim.SetBool(WALK_ANIMATION, false);    

        }
    }
}
