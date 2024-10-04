using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeController : MonoBehaviour
{

    public GameObject grenade;
    public GameObject explosionEffect;
    private float fuse = 3.0f;
    private float moveSpeed = 6.0f;

    


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (fuse<0)
        {
            Instantiate(explosionEffect, transform.position, transform.rotation);
            Destroy(collision.gameObject);
            Destroy(grenade);
        }
    }
}
