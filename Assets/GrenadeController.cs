using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeController : MonoBehaviour
{
    public Rigidbody2D grenade;

    // Start is called before the first frame update
    void Start()
    {
        grenade = GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void Update()
    {
       // grenade.velocity=Vector2(10,0,0);
    }
}
