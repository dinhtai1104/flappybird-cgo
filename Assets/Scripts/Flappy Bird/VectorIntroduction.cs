using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorIntroduction : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move(Vector3 steps)
    {
        // steps = vector3;
        this.transform.position += steps * Time.deltaTime * speed;
    }
}

//class Vector2
//{
//    float x;
//    float y;
//}
//class Vector3 : Vector2
//{
//    float z;
//}