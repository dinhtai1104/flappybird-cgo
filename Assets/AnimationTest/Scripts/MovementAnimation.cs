using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementAnimation : MonoBehaviour
{
    public float speedMove;
    public float jumpForce;
    public bool isMoving;
    public Animator animator;
    public Rigidbody2D myRb;
    // Start is called before the first frame update
    void Start()
    {
        myRb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement * speedMove * Time.deltaTime, 0, 0);
        // bien move = true|false
        if (movement == 0)
        {
            isMoving = false;

            // Check Jump
            if (Input.GetKeyDown(KeyCode.Space))
            {
                animator.SetBool("jump", true);
                myRb.velocity += new Vector2(0, jumpForce);
            }
        }
        else
        {
            isMoving = true;
        }

        if (movement > 0)
        {
            // phai
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (movement < 0)
        {
            // trai
            transform.localScale = new Vector3(-1, 1, 1);
        }

        animator.SetBool("move", isMoving);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        animator.SetBool("jump", false);
    }
}
