using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinkOneAI : MonoBehaviour
{
    public GameObject player;
    public GameObject pinkOne;
    public float moveSpeed = 1;
    public float distance;
    public GameObject minionSpawnArea;
    public GameObject projectileSpawnArea;
    public GameObject projectile;
    public float fireRate;
    public int phase = 0;
    public static int staticPinkOneHealth=1000;
    public int pinkOneHealth=1000;

    void Start()
    {
        moveSpeed = 2;
    }

    public static void PinkOneDamage(int damage)
    {
        staticPinkOneHealth-=damage;
    }


    // Update is called once per frame
    void Update()
    {

        pinkOneHealth = staticPinkOneHealth;
        if (pinkOneHealth>=666)
        {
            //Moves the entity this script is on towards the Player
            distance = Vector2.Distance(transform.position, player.transform.position);
            Vector2 direction = player.transform.position - transform.position;

            if (distance < 5)
            {
                transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, moveSpeed * Time.deltaTime);
            }

        }
        if (pinkOneHealth > 333 && pinkOneHealth < 666)
        {
            // Wizard type AI, move away and shoot
            moveSpeed = 1;
            distance = Vector2.Distance(transform.position, player.transform.position);
            Vector2 direction = player.transform.position - transform.position;

            if (distance>0&&distance<10)
            {
                transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, -moveSpeed * Time.deltaTime);
            }

            // On collision with a projectile tag, fetch the projectile.damageInt 

        }
        if (pinkOneHealth < 333 && pinkOneHealth > 0)
        {
            // Also spawn minions
        }
        if (pinkOneHealth <= 0)   
        {

        }
    }
}

