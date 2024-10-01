using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProMove : MonoBehaviour
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
        timeout = timeout+Time.deltaTime;
        projectile.velocity = transform.up*moveSpeedProjectile;
        if (timeout > 5 ) 
        {
            Destroy(gameObject);
            Debug.Log("Projectile Destroyed!");
        }
    }
}
