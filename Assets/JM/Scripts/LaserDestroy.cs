using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LaserDestroy : MonoBehaviour
{
    public SpawnLazer sl;
    // Start is called before the first frame update
    void Start()
    {
        sl = FindObjectOfType<SpawnLazer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    Debug.Log("Projectile has collided with the edge collider of the laser.");

    //    if (collision.gameObject.tag == this.gameObject.tag)
    //    {
    //        playerScore++;
    //        Debug.Log("Projectile matches the tag of the laser and has been destoryed.");
    //        collision.gameObject.SetActive(false);
    //        this.gameObject.SetActive(false);
    //    }
    //}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Projectile has collided with the edge collider of the laser.");

        if (collision.gameObject.tag == this.gameObject.tag)
        {
            
            Debug.Log("Projectile matches the tag of the laser and has been destoryed.");
            sl.ChangeScorebyIncrement(1);
            Destroy(collision.gameObject);
            this.gameObject.SetActive(false);
        }
        else
        {
            sl.ChangeScorebyIncrement(-1);
            Destroy(collision.gameObject);
            
        }
    }
}
