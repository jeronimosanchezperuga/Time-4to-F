using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public int freqInSeconds;
    float nextSpawnTime;

    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        nextSpawnTime = freqInSeconds;
    }

    // Update is called once per frame
    void Update()
    {
        if (nextSpawnTime <= Time.time)
        {
            GameObject clon;
            clon = Instantiate(prefab);
            Destroy(clon,5);
            nextSpawnTime += freqInSeconds;
        }
    }
}
