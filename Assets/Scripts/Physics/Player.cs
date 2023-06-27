using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D myRb;
    public float speed;
    public float jumpForce;
    public bool isOnGround;

    private void Update()
    {
        // Xử lý input
        // Di chuyển nhân vật bằng 2 phím mũi tên
        Movement();
        Jump();
        CheckOnGround();
    }
    protected void Movement()
    {
        // Get Input "Horionztal"
        float diChuyenTraiPhai = Input.GetAxis("Horizontal");
        //transform.position += new Vector3(diChuyenTraiPhai * Time.deltaTime * speed, 0, 0);
        myRb.velocity = new Vector2(diChuyenTraiPhai * speed, myRb.velocity.y);
    }
    protected void Jump()
    {
        if (isOnGround) // neu nhan vat dang dung tren nen dat thi cho phep nhay, nguoc lai thi khong
        {
            bool isJumpInput = Input.GetKeyDown(KeyCode.Space);
            if (isJumpInput)
            {
                // Jumping
                myRb.velocity += new Vector2(0, jumpForce);
            }
        }
    }
   
    protected void CheckOnGround()
    {
        //if (myRb.velocity.y > 0 || myRb.velocity.y < 0)
        //{
        //    isOnGround = false;
        //}
        //else
        //{
        //    isOnGround = true;
        //}
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Opacity")
        {
            collision.gameObject.SetActive(false);
            //// An spriterendere cua collsion
            //var spriteRenderer = collision.gameObject.GetComponent<SpriteRenderer>();
            //if (spriteRenderer != null)
            //{
            //    spriteRenderer.enabled = false;
            //}
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        string tagObject = collision.gameObject.tag;
        TagObject tagGO = collision.gameObject.GetComponent<TagObject>();

        if (tagGO != null)
        {
        }
        if (string.Equals(tagObject, "Ground"))
        {
            isOnGround = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        string tagObject = collision.gameObject.tag;
        if (string.Equals(tagObject, "Ground"))
        {
            isOnGround = false;
        }
    }
}
