using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProMove : MonoBehaviour
{

    // Initiate Variables and Classes Here
    public Rigidbody2D projectile;
    public int moveSpeedProjectile = 16;
    float timeout = 0;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeout = timeout+Time.deltaTime;
        projectile.velocity = Vector2.up*moveSpeedProjectile;
        if (timeout > 5 ) 
        {
            Destroy(gameObject);
            Debug.Log("Laser Destroyed!");
        }
    }
}
