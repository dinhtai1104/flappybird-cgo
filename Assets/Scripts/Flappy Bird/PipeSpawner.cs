using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public Transform spawnPosition;
    public float delayPerSpawn;

    private float currentTimeSpawn = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTimeSpawn > delayPerSpawn)
        {
            currentTimeSpawn = 0;
            // Spawn Pipe
            GameObject pipe = Instantiate(pipePrefab);
            pipe.transform.position = spawnPosition.position;
        }
        currentTimeSpawn += Time.deltaTime;
    }
}
