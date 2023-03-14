using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    public GameObject greenFireballPrefab; // Reference to the green fireball prefab
    public GameObject redFireballPrefab; // Reference to the red fireball prefab
    public GameObject blueFireballPrefab; // Reference to the blue fireball prefab
    public Transform firePoint; // Reference to the point where the fireball will spawn
    public float fireballSpeed = 5f; // The initial speed of the fireball
    public float fireballAcceleration = 2f; // The acceleration of the fireball

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            // Instantiate a green fireball and set its velocity
            GameObject greenFireball = Instantiate(greenFireballPrefab, firePoint.position, Quaternion.identity);
            greenFireball.GetComponent<Rigidbody2D>().velocity = new Vector2(fireballSpeed, 0f);
            fireballSpeed += fireballAcceleration;
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            // Instantiate a red fireball and set its velocity
            GameObject redFireball = Instantiate(redFireballPrefab, firePoint.position, Quaternion.identity);
            redFireball.GetComponent<Rigidbody2D>().velocity = new Vector2(fireballSpeed, 0f);
            fireballSpeed += fireballAcceleration;
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            // Instantiate a blue fireball and set its velocity
            GameObject blueFireball = Instantiate(blueFireballPrefab, firePoint.position, Quaternion.identity);
            blueFireball.GetComponent<Rigidbody2D>().velocity = new Vector2(fireballSpeed, 0f);
            fireballSpeed += fireballAcceleration;
        }
    }
}
