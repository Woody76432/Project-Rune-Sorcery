using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinkOneProjectile : MonoBehaviour
{
    public int moveSpeed = 6;
    public float timeout = 0;
    public GameObject player;
    public float distance;

    // Update is called once per frame
    void Update()
    {
        //Moves the entity this script is on towards the Player
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;
        timeout += Time.deltaTime;
        if (distance < 100)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, moveSpeed * Time.deltaTime);
        }

        if (timeout > 3)
        {
            Destroy(gameObject);
            Debug.Log("Projectile Destroyed!");
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
