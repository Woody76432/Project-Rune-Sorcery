using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeController : MonoBehaviour
{
    public Rigidbody2D grenade;
    public float grenadeFuse = 2;
    public GameObject explosionEffect;

    // Start is called before the first frame update
    void Start()
    {
        grenade = GetComponent<Rigidbody2D>();
        grenade.velocity = new Vector3(0, 10, 0);
    }

    // Update is called once per frame
    void Update()
    {
        grenadeFuse-=Time.deltaTime;
        if (grenadeFuse <= 0)
        {
            Detonate();
            if (grenadeFuse<=-0.5)
            {
               
                Destroy(gameObject);
                Instantiate(explosionEffect,transform.position,transform.rotation); 
            }
        }
    }
    private void Detonate()
    {
        void OnTriggerEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag=="enemy")
            {
                Destroy(collision.gameObject);
            }
        }
    }
}
