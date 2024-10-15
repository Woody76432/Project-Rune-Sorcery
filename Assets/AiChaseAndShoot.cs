using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiChaseAndShoot : MonoBehaviour
{

    public GameObject player;
    public Transform playerTransform;
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
            // Repurposed From rotate to cursor
            // Trigonometry to calculate the difference between where the mouse is to where the player is
            Vector3 rotationDifference = this.transform.position - player.transform.position;
            float rotationZ = Mathf.Atan2(rotationDifference.y, rotationDifference.x) * Mathf.Rad2Deg;
            //Rotates the enemy to follow the rotationZ, the 2 floats would be for 3D
            //Plus 90 to change the orientation centering
            this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ + 90);
        }

        

        //Moves the entity this script is on towards the Player
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;

        if (distance < 8 && distance >4)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, (moveSpeed * 2f) * Time.deltaTime);
            isTargeting = true;
        }
        //Run Away
        if (distance < 3)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, -(moveSpeed * 1.5f) * Time.deltaTime);
            isTargeting = false;

            Vector3 rotationDifference = this.transform.position - player.transform.position;
            float rotationZ = Mathf.Atan2(rotationDifference.y, rotationDifference.x) * Mathf.Rad2Deg;
            //Rotates the enemy to follow the rotationZ, the 2 floats would be for 3D
            //Plus 90 to change the orientation centering
            this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ+180 + 90);
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
                    Instantiate(projectile,projectileSpawnLocation.transform.position, this.transform.rotation);

                }
            }
        }
        if (distance <= 0.5)
        {
            Destroy(ghostWizard);
        }
    }
}
