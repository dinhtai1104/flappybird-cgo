using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Bat dau va cham
        if (collision.gameObject.name == "Qua bong")
        {
            Debug.Log(gameObject.name + " starts collide with " + collision.gameObject.name);
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        // Dang va cham
        Debug.Log(gameObject.name + " is colliding with " + collision.gameObject.name);
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        // Ket thuc va cham
        Debug.Log(gameObject.name + " end collide with " + collision.gameObject.name);
    }
}
