using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpForce;
    public float jumpAngle;
    public float angleRotateSpeed;
    public Animator animator;
    private void Start()
    {
        rb.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // Khi nhảy => chim bay lên
        // Bay lên như thế nào? => truyền vận tốc theo chiều hướng lên trên
        // Xác định khi bấm vào màn hình
        if (GameManager.Instance.isEndGame) return;

        bool isTap = Input.GetKeyDown(KeyCode.Space);

        if (isTap)
        {
            Jump();
        }
        if (GameManager.Instance.isStartGame == false) return;
        RotateBird();
    }

    public void StartGame()
    {
        rb.gravityScale = 1;
    }

    public void Dead()
    {
        animator.enabled = false;
    }

    protected void RotateBird()
    {
        transform.eulerAngles -= new Vector3(0, 0, angleRotateSpeed * Time.deltaTime);
    }

    protected void Jump()
    {
        rb.velocity = Vector2.up * jumpForce; // Nhảy lên khi nhấn phím nhảy
        transform.eulerAngles = new Vector3(0, 0, jumpAngle);
        AudioManager.Instance.PlayFlapBirdAudio();
    }
}
