using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public GameObject impactPrefab;
    public Collider2D[] laserColliders;
    public GameObject loseScene;

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (ArrayContainsCollider(laserColliders, collision))
    //    {
    //        Instantiate impact prefab in the player's position
    //        Instantiate(impactPrefab, transform.position, Quaternion.identity);

    //        Load the lose scene
    //        SceneManager.LoadScene(loseSceneName);

    //        Destroy the player game object
    //        Destroy(gameObject);
    //    }
    //}

    //private bool ArrayContainsCollider(Collider2D[] array, Collider2D collider)
    //{
    //    foreach (Collider2D item in array)
    //    {
    //        if (item == collider)
    //        {
    //            return true;
    //        }
    //    }

    //    return false;
    //}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(impactPrefab, transform.position, Quaternion.identity);

        loseScene.gameObject.SetActive(true);

    }
}
