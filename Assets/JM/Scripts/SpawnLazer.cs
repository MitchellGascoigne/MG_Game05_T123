using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLazer : MonoBehaviour
{

    public GameObject[] lazers;
    public Transform initialSpawnPoint;
    public float lazerSpawnDelay;

    public float distanceBetweenSpawns;

    private Vector3 newSpawn;

    // Start is called before the first frame update
    void Start()
    {
        newSpawn = initialSpawnPoint.position;
        StartCoroutine(RandomLazerSpawner());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator RandomLazerSpawner()
    {
        

        yield return new WaitForSeconds(lazerSpawnDelay);

        Instantiate(lazers[Random.Range(0, lazers.Length)], newSpawn, Quaternion.identity);

        newSpawn.x += distanceBetweenSpawns;

        StartCoroutine(RandomLazerSpawner());
    }
  
}
