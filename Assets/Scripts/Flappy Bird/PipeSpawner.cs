using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public Transform spawnPosition;
    public float delayPerSpawn;
    public Vector2 offsetPipeSpawn;
    private float currentTimeSpawn = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.isStartGame == false) return;
        if (GameManager.Instance.isEndGame) return;
        if (currentTimeSpawn > delayPerSpawn)
        {
            currentTimeSpawn = 0;
            SpawnPipe();
        }
        currentTimeSpawn += Time.deltaTime;
    }

    private void SpawnPipe()
    {
        // Spawn Pipe
        GameObject pipe = Instantiate(pipePrefab);
        pipe.transform.position = spawnPosition.position;
        var offset = Random.Range(offsetPipeSpawn.x, offsetPipeSpawn.y);
        pipe.transform.position += new Vector3(0, offset);
    }
}
