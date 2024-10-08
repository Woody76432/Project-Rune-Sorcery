using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    public GameObject projectile;
    public Rigidbody2D explosionEffect;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            //Destroys both the collided gameObject and also the projectile
            Instantiate(explosionEffect, transform.position, transform.rotation);
            Destroy(collision.gameObject);
            Destroy(projectile);
            Player.SetScore(250);
        }
        else

        {
            //Destroys the projectile if it collides with any unspecified collision boxes as a failsafe ( Includes Walls )
            Destroy(projectile);
            Instantiate(explosionEffect, transform.position, transform.rotation);
        }
    }
}
