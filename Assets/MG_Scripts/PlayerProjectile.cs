using UnityEngine;
using System.Collections;

public class PlayerProjectile : MonoBehaviour
{
    public GameObject greenFireballPrefab;
    public GameObject redFireballPrefab;
    public GameObject blueFireballPrefab;
    public Transform firePoint;
    public float fireballSpeed = 30f;
    public float spawnWaitTime = 1f;

    private bool canSpawn = true;

    void Update()
    {
        if (canSpawn)
        {
            if (Input.GetKeyDown(KeyCode.R) && !Input.GetKey(KeyCode.G) && !Input.GetKey(KeyCode.B))
            {
                SpawnProjectile(redFireballPrefab);
            }
            else if (Input.GetKeyDown(KeyCode.G) && !Input.GetKey(KeyCode.R) && !Input.GetKey(KeyCode.B))
            {
                SpawnProjectile(greenFireballPrefab);
            }
            else if (Input.GetKeyDown(KeyCode.B) && !Input.GetKey(KeyCode.R) && !Input.GetKey(KeyCode.G))
            {
                SpawnProjectile(blueFireballPrefab);
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
