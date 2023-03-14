using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    public GameObject greenFireballPrefab;
    public GameObject redFireballPrefab;
    public GameObject blueFireballPrefab;
    public GameObject yellowFireballPrefab;
    public GameObject cyanFireballPrefab;
    public GameObject purpleFireballPrefab;
    public Transform firePoint;
    public float fireballSpeed = 30f;

    void Update()
    {
        if (Input.GetKey(KeyCode.G) && Input.GetKey(KeyCode.R))
        {
            Instantiate(yellowFireballPrefab, firePoint.position, Quaternion.identity)
                .GetComponent<Rigidbody2D>().velocity = new Vector2(fireballSpeed, 0f);
        }
        else if (Input.GetKey(KeyCode.G) && Input.GetKey(KeyCode.B))
        {
            Instantiate(cyanFireballPrefab, firePoint.position, Quaternion.identity)
                .GetComponent<Rigidbody2D>().velocity = new Vector2(fireballSpeed, 0f);
        }
        else if (Input.GetKey(KeyCode.R) && Input.GetKey(KeyCode.B))
        {
            Instantiate(purpleFireballPrefab, firePoint.position, Quaternion.identity)
                .GetComponent<Rigidbody2D>().velocity = new Vector2(fireballSpeed, 0f);
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            Instantiate(greenFireballPrefab, firePoint.position, Quaternion.identity)
                .GetComponent<Rigidbody2D>().velocity = new Vector2(fireballSpeed, 0f);
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            Instantiate(redFireballPrefab, firePoint.position, Quaternion.identity)
                .GetComponent<Rigidbody2D>().velocity = new Vector2(fireballSpeed, 0f);
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(blueFireballPrefab, firePoint.position, Quaternion.identity)
                .GetComponent<Rigidbody2D>().velocity = new Vector2(fireballSpeed, 0f);
        }
    }
}

