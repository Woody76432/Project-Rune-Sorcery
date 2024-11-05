using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiChaseAndShoot : MonoBehaviour
{

    public GameObject player;
    public float moveSpeed;
    public float shootCooldown = 0;
    public float distance;
    public bool isTargeting = false;
    public float shootSpeed = 2;
    public GameObject projectile;
    public GameObject projectileSpawnLocation; 
    public GameObject ghostWizard;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {



        if (isTargeting==true)
        {
            shootCooldown -= Time.deltaTime;
        }

        

        //Moves the entity this script is on towards the Player
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;

        // If distance is between these move towards and fire
        if (distance < 8 && distance >3)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, (moveSpeed * 2f) * Time.deltaTime);
            isTargeting = true;
        }
        //Run Away
        if (distance < 2.50000000000000000001)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, -(moveSpeed * 1.5f) * Time.deltaTime);
            isTargeting = false;
        }
        // Disables Chasing
        if (distance>10)
        {
            isTargeting = false;
        }
        // Shoot at player
        else if (distance > 1)
        {
            if (isTargeting == true)
            {
                if (shootCooldown < 0)
                {
                    shootCooldown = shootSpeed;
                    Debug.Log("Fired Ball at player");
                    Instantiate(projectile,projectileSpawnLocation.transform.position, projectileSpawnLocation.transform.rotation);

                }
            }
        }
        if (distance <= 0.5)
        {
            Destroy(ghostWizard);
        }
    }
}
