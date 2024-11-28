using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIChase : MonoBehaviour
{
    public GameObject player;
    public float moveSpeed;
    public float distance;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("player");

    }

    // Update is called once per frame
    void Update()
    {
        //Moves the entity this script is on towards the Player
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;

        if (distance<5)
        {
            transform.position=Vector2.MoveTowards(this.transform.position, player.transform.position,moveSpeed*Time.deltaTime);
        }
    }
}
