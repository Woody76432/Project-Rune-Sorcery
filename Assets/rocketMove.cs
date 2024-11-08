using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class rocketMove : MonoBehaviour
{
    int numOfEnemiesHit = 0;
    public int moveSpeed = 3;
    public Rigidbody2D rocket;
    float timeout = 0;
    public GameObject explosionEffect;
    public int randInt = 0;

    private void Start()
    {
        rocket = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        int lowerBound = (int)gameObject.transform.rotation.z - 20;
        int upperBound = (int)gameObject.transform.rotation.z + 20;
        if (numOfEnemiesHit == 2)
        {
            Destroy(gameObject);
            Instantiate(explosionEffect, transform.position, transform.rotation);
        }

        timeout =+ Time.deltaTime;
        rocket.velocity = transform.up * moveSpeed;
        if (timeout > 5)
        {
            Destroy(gameObject);
            Debug.Log("Rocket Destroyed!");
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        numOfEnemiesHit++;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            Destroy(collision.gameObject);
            Instantiate(explosionEffect, transform.position, transform.rotation);
        }
        else
        {
            Instantiate(explosionEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
