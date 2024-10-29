using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProSpawn : MonoBehaviour
{
    public GameObject projectile;
    public GameObject grenade;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) 
        {
            Instantiate(projectile,transform.position,transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (Abilities.ability1Cooldown == -75f)
            {
                Instantiate(grenade, transform.position, transform.rotation);
            }
        }
    }
}
