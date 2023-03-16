using UnityEngine;
using System.Collections;

public class PlayerProjectile : MonoBehaviour
{
    
    public GameObject greenFireballPrefab;
    public GameObject redFireballPrefab;
    public GameObject blueFireballPrefab, MagentaFireballPrefab, YellowFireballPrefab, CyanFireballPrefab;
    public Transform firePoint;
    public float fireballSpeed = 30f;
    public float spawnWaitTime = 0.5f;

    private bool canSpawn = true;

    void Update()
    {


        if (Input.GetKey(KeyCode.R))
        {
            if (Input.GetKey(KeyCode.G))
            {
                if(canSpawn)
                SpawnProjectile(YellowFireballPrefab);

            }
            else if (Input.GetKey(KeyCode.B))
            {
                if (canSpawn)
                    SpawnProjectile(MagentaFireballPrefab);
            }
            else
            {
                if (canSpawn)
                    SpawnProjectile(redFireballPrefab);

            }
        }

        if (Input.GetKey(KeyCode.B))
        {
            if (Input.GetKey(KeyCode.G))
            {
                if (canSpawn)
                    SpawnProjectile(CyanFireballPrefab);

            }
            else if(Input.GetKey(KeyCode.R))
            {
                if (canSpawn)
                    SpawnProjectile(MagentaFireballPrefab);

            }
            else
            {
                if (canSpawn)
                    SpawnProjectile(blueFireballPrefab);
            }
        }

        if (Input.GetKey(KeyCode.G))
        {
            if (Input.GetKey(KeyCode.B))
            {
                if (canSpawn)
                    SpawnProjectile(CyanFireballPrefab);
            }
            else if (Input.GetKey(KeyCode.R))
            {
                if (canSpawn)
                    SpawnProjectile(YellowFireballPrefab);
            }
            else
            {
                if (canSpawn)
                    SpawnProjectile(greenFireballPrefab);

            }
        }

       

    }

    void SpawnProjectile(GameObject prefab)
    {
        canSpawn = false;
        GameObject fireball = Instantiate(prefab, firePoint.position, Quaternion.identity);
        fireball.GetComponent<Rigidbody2D>().velocity = new Vector2(fireballSpeed, 0f);
        Destroy(fireball, 3f);
        StartCoroutine(WaitForSpawn());
    }

    IEnumerator WaitForSpawn()
    {
        yield return new WaitForSeconds(spawnWaitTime);
        canSpawn = true;
    }
}

