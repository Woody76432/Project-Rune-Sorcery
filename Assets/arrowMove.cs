using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowMove : MonoBehaviour
{
    public int moveSpeed = 3;
    public Rigidbody2D arrow;
    float timeout = 0;
    public GameObject explosionEffect;

    private void Start()
    {
        arrow = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        timeout = +Time.deltaTime;
        arrow.velocity = transform.up * moveSpeed;
        if (timeout > 5)
        {
            Destroy(gameObject);
            Debug.Log("Arrow Destroyed!");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            Destroy(collision.gameObject);
            ItemDropping.SpawnItem(this.transform.position, this.transform.rotation);
            Instantiate(explosionEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
        else
        {
            Instantiate(explosionEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}

