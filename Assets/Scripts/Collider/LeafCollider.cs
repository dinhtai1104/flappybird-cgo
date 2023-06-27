using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeafCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(gameObject.name + " starts trigger collide with " + collision.gameObject.name);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log(gameObject.name + " colliding trigger with " + collision.gameObject.name);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log(gameObject.name + "end trigger colliding with " + collision.gameObject.name);
    }
}
