using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinkOneAI : MonoBehaviour
{
    public GameObject player;
    public float moveSpeed;
    public float distance;
    public int pinkOneHealth = 1000;
    public gameObject minionSpawnArea;
    public gameObject projectileSpawnArea;
    public gameObject projectile;
    public float fireRate;
    public int phase = 0;

    public static void PinkOneDamage(int damage)
    {
        pinkOneHealth-=damage;
    }


    // Update is called once per frame
    void Update()
    {
        if (pinkOneHealth>666)
        {
            //Moves the entity this script is on towards the Player
            distance = Vector2.Distance(transform.position, player.transform.position);
            Vector2 direction = player.transform.position - transform.position;
            if (distance < 10)
            {
                transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, moveSpeed * Time.deltaTime);
            }
        }
        if (pinkOneHealth > 333 && pinkOneHealth < 666)
        {
            // Wizard type AI, move away and shoot
        }
        if (pinkOneHealth < 333 && pinkOneHealth > 0)
        {
            // Also spawn minions
        }
        if (pinkOneHealth=<0)
        {

        }
    }
}

