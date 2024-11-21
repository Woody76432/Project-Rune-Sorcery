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
    public int pinkOneHealth=100;
    public float minionSpawnCooldown = 3;
    public GameObject meleeMinion;
    public GameObject rangedMinion;

    void Start()
    {
        moveSpeed = 2;
    }

    public void Damage(int damage)
    {
        pinkOneHealth-=damage;
        Debug.Log(pinkOneHealth.ToString());
    }


    // Update is called once per frame
    void Update()
    {
        if (pinkOneHealth>=66)
        {
            moveSpeed = 3;
            //Moves the entity this script is on towards the Player
            distance = Vector2.Distance(transform.position, player.transform.position);
            Vector2 direction = player.transform.position - transform.position;

            if (distance < 10)
            {
                transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, moveSpeed * Time.deltaTime);
            }

        }
        if (pinkOneHealth > 33 && pinkOneHealth < 66)
        {
            // Wizard type AI, move away and shoot
            moveSpeed = 2;
            distance = Vector2.Distance(transform.position, player.transform.position);
            Vector2 direction = player.transform.position - transform.position;

            // If the player is within a 10 unit range :
            if (distance>0&&distance<10)
            {
                // If within range AND too close :
                if (distance > 0 && distance < 3)
                {
                    transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, -moveSpeed * Time.deltaTime);
                }
                // If within range AND too far :
                if (distance > 4 &&distance < 10)
                {
                    transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, moveSpeed * Time.deltaTime);
                }
            }
        }
        if (pinkOneHealth < 33 && pinkOneHealth > 0)
        {
            moveSpeed = 4;
            distance = Vector2.Distance(transform.position, player.transform.position);
            Vector2 direction = player.transform.position - transform.position;

            // If the player is within a 10 unit range :
            if (distance > 0 && distance < 10)
            {
                // If within range AND too close :
                if (distance > 0 && distance < 3)
                {
                    transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, -moveSpeed * Time.deltaTime);
                }
                // If within range AND too far :
                if (distance > 4 && distance < 10)
                {
                    transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, moveSpeed * Time.deltaTime);
                }
            }
            if (minionSpawnCooldown<=0)
            {
                int randInt = Random.Range(0, 10);
                if (randInt < 5)
                {
                    Instantiate(meleeMinion, minionSpawnArea.transform.position, minionSpawnArea.transform.rotation);
                    minionSpawnCooldown = 3;
                }
                else
                {
                    Instantiate(rangedMinion, minionSpawnArea.transform.position, minionSpawnArea.transform.rotation);
                    minionSpawnCooldown = 3;

                }
            }

            // Also spawn minions
        }
        if (pinkOneHealth <= 0)
        {
            // Die
            Destroy(gameObject);
        }
        minionSpawnCooldown-=Time.deltaTime;    
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="projectile")
        {
            Damage(1);
        }
    }
}

