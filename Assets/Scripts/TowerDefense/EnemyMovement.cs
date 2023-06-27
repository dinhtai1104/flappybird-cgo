using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;
    public int direction; // 1: Right; -1: Left;
    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(direction * Time.deltaTime * speed, 0, 0);
    }
}
