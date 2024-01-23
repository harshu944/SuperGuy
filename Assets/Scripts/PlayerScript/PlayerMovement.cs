using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 5f;

    public LayerMask groundLayer;
    private Rigidbody2D mybody;
    private Animator anim;
    public Transform groundCheckPosition;
    public Joystick joystick;
    float horizontalMove = 0f;
  

    private bool isGrounded;
    private bool jumped;

    private float jumpPower = 12f;
    void Awake()
    {
       
        mybody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
       
    }
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
       
        CheckIfGrounded();
        PlayerJump();
    }
    void FixedUpdate()
    {
        PlayerWalk();
    }

    void PlayerWalk()
    {
        horizontalMove = joystick.Horizontal * speed;
        
       
        if (joystick.Horizontal>=.2f)
        {
            mybody.velocity = new Vector2(speed, mybody.velocity.y);
          
            ChangeDirection(5);

        }
        else if (joystick.Horizontal<=-.2f)
        {
            mybody.velocity = new Vector2(-speed, mybody.velocity.y);
            
            ChangeDirection(-5);
        }
        else
        {
            mybody.velocity = new Vector2(0f, mybody.velocity.y);
        }
       
        anim.SetInteger("speed", Mathf.Abs((int)mybody.velocity.x));
    }
    void ChangeDirection(int direction)
    {
        Vector3 tempScale = transform.localScale;       
        tempScale.x = direction;
        transform.localScale = tempScale;
    }



    void CheckIfGrounded()
    {
        isGrounded = Physics2D.Raycast(groundCheckPosition.position, Vector2.down,0.1f,groundLayer);


        if (isGrounded)
        {
            if (jumped)
            {
                jumped = false;
                anim.SetBool("Jump", false);
            }
        }
    }
    void PlayerJump()
    {
        float verticalMove = joystick.Vertical;
        if (isGrounded)
        {
            if(verticalMove>=.5f)
            {
                jumped = true;
                mybody.velocity = new Vector2(mybody.velocity.x, jumpPower);
                anim.SetBool("Jump", true);
            }
        }
    }
}
