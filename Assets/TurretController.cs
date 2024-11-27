using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretController : MonoBehaviour
{

    public GameObject player;
    public float shootCooldown = 0;
    public float distance;
    public bool isTargeting = false;
    public float shootSpeed = 2;
    public GameObject projectile;
    public GameObject projectileSpawnLocation;
    public GameObject turret;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("player");
    }

    // Update is called once per frame
    void Update()
    {
        shootCooldown -= Time.deltaTime;
        distance = Vector2.Distance(transform.position, player.transform.position);

        // Shoot at player
        if (distance < 10)
        {
            if (shootCooldown <= 0)
            {
                shootCooldown = shootSpeed;
                Debug.Log("Turret fired bullet at player");
                Instantiate(projectile, projectileSpawnLocation.transform.position, projectileSpawnLocation.transform.rotation);

            }
        }
    }
}
