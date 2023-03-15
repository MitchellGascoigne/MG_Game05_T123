using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserSpawner : MonoBehaviour
{
    public GameObject[] laserPrefabs;
    public float minSpawnDelay = 2f;
    public float maxSpawnDelay = 8f;
    public float spawnY = 0f;

    private float nextSpawnTime;

    void Start()
    {
        // Set the initial spawn time
        nextSpawnTime = Time.time + Random.Range(minSpawnDelay, maxSpawnDelay);
    }

    void Update()
    {
        // Check if it's time to spawn a new laser
        if (Time.time >= nextSpawnTime)
        {
            // Randomly select one of the laser prefabs
            int index = Random.Range(0, laserPrefabs.Length);
           

            Debug.Log("index chosen was: " + index);


            // ==== Commented out and ammended script due to compiling errors.

            //GameObject laserPrefab = laserPrefabs[index];    

            // Spawn the laser at the specified Y position and a random X position just outside the camera
            float spawnX = Camera.main.ViewportToWorldPoint(new Vector3(1.1f, 0f, 0f)).x;
            Vector3 spawnPos = new Vector3(spawnX, spawnY, 0f);
            Instantiate(laserPrefabs[index], spawnPos, Quaternion.identity);

            // Set the next spawn time
            nextSpawnTime = Time.time + Random.Range(minSpawnDelay, maxSpawnDelay);
        }
    }
}
