using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomDoorTrigger : MonoBehaviour
{
    public GameObject door1;
    public GameObject door2;
    public GameObject door3;
    // Add more doors here if you need them, make sure to add them elsewhere too

    public bool enemiesInTrigger = true;
    public bool playerInTrigger = false;
    public bool triggerActivated = false;
    public float timeInTrigger = 0;
    public float enemyTimeOutTrigger = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="player")
        {
            playerInTrigger = true;
        }
        if (collision.gameObject.tag == "enemy")
        {
            enemiesInTrigger = true;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            enemiesInTrigger = true;
            enemyTimeOutTrigger = 0;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            enemiesInTrigger = false;
        }
        if (collision.gameObject.tag == "player")
        {
            playerInTrigger = false;
        }
    }

    void Update()
    {
        if (enemiesInTrigger==false) 
        {
            enemyTimeOutTrigger += Time.deltaTime;
        }
        if (playerInTrigger==false&&triggerActivated == true)
        {
            door1.SetActive(false);
            door2.SetActive(false);
            door3.SetActive(false);
            triggerActivated = false;
        }
        if (enemiesInTrigger == false&&enemyTimeOutTrigger>1)
        {
            door1.SetActive(false);
            door2.SetActive(false);
            door3.SetActive(false);
            Destroy(gameObject);
        }
        if (playerInTrigger == true)
        {
            timeInTrigger += Time.deltaTime;
            if (triggerActivated == false)
            {
                if (timeInTrigger > 0.5)
                {
                    door1.SetActive(true);
                    door2.SetActive(true);
                    door3.SetActive(true);
                    triggerActivated = true;
                }

            }
        }


    }
}
