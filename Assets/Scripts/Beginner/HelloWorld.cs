using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake is called");
    }
    private void OnEnable()
    {
        Debug.Log("OnEnable is called");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start is called");
    }

    private void Update()
    {
        
    }

    private void OnDisable()
    {
        Debug.Log("OnDisable is called");
    }
    private void OnDestroy()
    {
        Debug.Log("OnDestroy is called");
    }
}
