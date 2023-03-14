using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //runs cotroutine on projectile spawn
        StartCoroutine(DestroyProjectile());
    }

    // waiitng 2 seconds after spawn to destroy
    public IEnumerator DestroyProjectile()
    {

        yield return new WaitForSeconds(2f);

        Destroy(this.gameObject);
    }

}
