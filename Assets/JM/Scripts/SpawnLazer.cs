using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLazer : MonoBehaviour
{
    public TMPro.TextMeshProUGUI tmpScoreText;
    private int playerScore;

    public GameObject[] lazers;
    public Transform initialSpawnPoint;
    public float lazerSpawnDelay;

    public float distanceBetweenSpawns;

    private Vector3 newSpawn;

    // Start is called before the first frame update
    void Start()
    {
        playerScore = 0;
        newSpawn = initialSpawnPoint.position;
        StartCoroutine(RandomLazerSpawner());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator RandomLazerSpawner()
    {
        Debug.Log("Random Lazer Spawner method called.");

        yield return new WaitForSeconds(lazerSpawnDelay);

        Debug.Log("method waited for " + lazerSpawnDelay + " seconds");

        int index = Random.Range(0, lazers.Length);

        Instantiate(lazers[index], newSpawn, Quaternion.identity);

        Debug.Log("method spawned a laser of index " + index + " at the location of " + newSpawn);

        newSpawn.x += distanceBetweenSpawns;

        StartCoroutine(RandomLazerSpawner());
    }

    public void ChangeScorebyIncrement(int i)
    {
        playerScore += i;
        tmpScoreText.text = playerScore.ToString();
    }
  
}
