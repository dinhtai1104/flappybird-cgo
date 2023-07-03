using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public Transform startPos;
    public Transform endPos;
    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.isEndGame) return;

        // if Bird Die => return
        this.transform.position += Vector3.left * GameManager.Instance.speed * Time.deltaTime;
        if (transform.position.x < endPos.position.x)
        {
            transform.position = startPos.position;
        }
    }
}
