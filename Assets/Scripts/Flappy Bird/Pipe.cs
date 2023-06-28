using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float speed;
    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.isEndGame) return;

        // if Bird Die => return
        this.transform.position += Vector3.left * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Destroy")
        {
            Destroy(gameObject);
        }
    }
}
