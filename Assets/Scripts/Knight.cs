using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : MonoBehaviour
{
    public Sword sword;
    // Start is called before the first frame update
    void Start()
    {
        sword.Equip();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
