using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public GameObject impactPrefab;
    public Collider2D[] laserColliders;
    public string loseSceneName;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (ArrayContainsCollider(laserColliders, collision))
        {
            // Instantiate impact prefab in the player's position
            Instantiate(impactPrefab, transform.position, Quaternion.identity);

            // Load the lose scene
            SceneManager.LoadScene(loseSceneName);

            // Destroy the player game object
            Destroy(gameObject);
        }
    }

    private bool ArrayContainsCollider(Collider2D[] array, Collider2D collider)
    {
        foreach (Collider2D item in array)
        {
            if (item == collider)
            {
                return true;
            }
        }

        return false;
    }
}
