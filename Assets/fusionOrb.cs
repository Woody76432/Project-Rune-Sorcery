using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fusionOrb : MonoBehaviour
{
    private int numOfHitEnemies = 0;
    private float timeout = 0;
    public Rigidbody2D orb;

    // Update is called once per frame
    void Update()
    {
        timeout += Time.deltaTime;
        if (timeout > 5)
        {
            Destroy(gameObject);
        }

        orb.velocity = transform.up * 1;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="wall")
        {
            Destroy(gameObject);
        }

        if (numOfHitEnemies <= 3 && collision.gameObject.tag == "enemy")
        {
            Destroy(collision.gameObject);
            numOfHitEnemies++;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
