using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject Pipe;
    public float spawnRate = 2;
    public float timer = 0;
    public float hightOffSet = 10;
    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        { 
            SpawnPipe();
            timer = 0;
        }
    }
    void SpawnPipe()
    {
        float lowestPoint = transform.position.y - hightOffSet;
        float highestPoint = transform.position.y + hightOffSet;
        Instantiate(Pipe, new Vector3(transform.position.x, Random.Range(lowestPoint,highestPoint), 0) , transform.rotation);
    }
}
