using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MimicAI : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public GameObject spawner;
    public GameObject mimicEnemy;
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

        if (distance < 7)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, moveSpeed * Time.deltaTime);
        }
        else
        {
            mimicEnemy.SetActive(false);
        }
    }
}
