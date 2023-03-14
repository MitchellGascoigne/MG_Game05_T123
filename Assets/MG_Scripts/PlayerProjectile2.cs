using UnityEngine;
using System.Collections;

public class PlayerProjectile2 : MonoBehaviour
{
    public GameObject greenFireballPrefab;
    public GameObject redFireballPrefab;
    public GameObject blueFireballPrefab;
    public GameObject yellowFireballPrefab;
    public GameObject cyanFireballPrefab;
    public GameObject purpleFireballPrefab;

    public Transform firePoint;
    public float fireballSpeed = 30f;
    public float spawnWaitTime = 1f;

    private KeyCode[] currentKeys = new KeyCode[2];

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            if (Input.GetKey(KeyCode.R))
            {
                SpawnProjectile(yellowFireballPrefab);
                currentKeys = new KeyCode[2];
            }
            else if (Input.GetKey(KeyCode.B))
            {
                SpawnProjectile(cyanFireballPrefab);
                currentKeys = new KeyCode[2];
            }
            else
            {
                currentKeys[0] = KeyCode.G;
            }
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            if (Input.GetKey(KeyCode.G))
            {
                SpawnProjectile(yellowFireballPrefab);
                currentKeys = new KeyCode[2];
            }
            else if (Input.GetKey(KeyCode.B))
            {
                SpawnProjectile(purpleFireballPrefab);
                currentKeys = new KeyCode[2];
            }
            else
            {
                currentKeys[0] = KeyCode.R;
            }
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            if (Input.GetKey(KeyCode.G))
            {
                SpawnProjectile(cyanFireballPrefab);
                currentKeys = new KeyCode[2];
            }
            else if (Input.GetKey(KeyCode.R))
            {
                SpawnProjectile(purpleFireballPrefab);
                currentKeys = new KeyCode[2];
            }
            else
            {
                currentKeys[0] = KeyCode.B;
            }
        }

        // Update the current keys array
        if (Input.anyKeyDown)
        {
            int i = 0;
            foreach (KeyCode keyCode in System.Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKey(keyCode) && i < 2)
                {
                    currentKeys[i++] = keyCode;
                }
            }
        }
    }

    IEnumerator SpawnProjectileWithDelay(GameObject prefab)
    {
        GameObject fireball = Instantiate(prefab, firePoint.position, Quaternion.identity);
        fireball.GetComponent<Rigidbody2D>().velocity = new Vector2(fireballSpeed, 0f);
        Destroy(fireball, 3f);

        yield return new WaitForSeconds(spawnWaitTime);
    }

    void SpawnProjectile(GameObject prefab)
    {
        StartCoroutine(SpawnProjectileWithDelay(prefab));
    }
}
