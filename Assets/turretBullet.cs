using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turretBullet : MonoBehaviour
{

    // Initiate Variables and Classes Here
    public Rigidbody2D projectile;
    public float moveSpeedProjectile = 25f;
    float timeout = 0;



    // Start is called before the first frame update
    void Start()
    {
        projectile = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        timeout = timeout + Time.deltaTime;
        projectile.velocity = transform.up * moveSpeedProjectile;
        if (timeout > 1)
        {
            Destroy(gameObject);
            Debug.Log("Projectile Destroyed!");
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "walls")
        {
            Destroy(gameObject );
        }
    }
}
