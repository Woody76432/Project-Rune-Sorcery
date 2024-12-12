using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MimicSpawner : MonoBehaviour
{
    public GameObject mimicEnemy;
    public GameObject player;
    public float moveSpeed = 2;
    public float distance;
    private bool triggerMimic = false;

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="player")
        {
            mimicEnemy.SetActive(true);
            triggerMimic = true;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("player");
        moveSpeed = 4;
    }

    // Update is called once per frame
    void Update()
    {
        //Moves the entity this script is on towards the Player
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;

        if (distance < 7 && triggerMimic == true)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, moveSpeed * Time.deltaTime);
        }
        else
        {
            triggerMimic=false;
            mimicEnemy.SetActive(false);
        }
    }
}
