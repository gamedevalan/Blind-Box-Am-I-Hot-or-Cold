using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed=300f;
    public float jumpForce=10f;
    public float moveInput;
    public Rigidbody2D rb;

    private bool isGrounded;
    private bool isGrounded2;
    public Transform groundCheck;
    public Transform groundCheck2;
    public float checkRadius;
    public LayerMask whatisGround;

    private float extraJump;
    public float extraJumpValue=1;

    private bool facingRight = true;


    // Start is called before the first frame update
    void Start()
    {
        extraJump = extraJumpValue;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2((moveInput * speed)*Time.deltaTime, rb.velocity.y);

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatisGround);
        isGrounded2 = Physics2D.OverlapCircle(groundCheck2.position, checkRadius, whatisGround);
        if (rb.position.y < 1.4f)
        {
            FindObjectOfType<FollowPlayerDeath>().Death();
            FindObjectOfType<GameManage>().EndGameFall();
        }

    }
    void Update()
    {
        if (isGrounded==true&& isGrounded2 == true)
        {
            extraJump = extraJumpValue;
        }

        if (isGrounded == false&& isGrounded2 == false)
        {
            extraJump = 0;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && extraJump > 0)
        {
            //SoundManagerScript.PlaySound("Jump");
            rb.velocity = Vector2.up * jumpForce;
            extraJump--;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) && extraJump==0&&isGrounded==true)
        {
           // SoundManagerScript.PlaySound("Jump");
            rb.velocity = Vector2.up * jumpForce;
        }

        
            if(moveInput > 0 && !facingRight)
            {
            facingRight = !facingRight;
            transform.Rotate(0,180,0);
            }

            else if (moveInput < 0 && facingRight)
            {
            facingRight = !facingRight;
            transform.Rotate(0, 180, 0);
            }
        
    }
}
