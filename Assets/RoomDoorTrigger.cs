using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomDoorTrigger : MonoBehaviour
{
    public GameObject door1;
    public GameObject door2;
    public GameObject door3;
    public GameObject door4;
    public GameObject door5;
    public GameObject door6;

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
            enemieTimeInTrigger = 0;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            enemyTimeOutTrigger += timeInTrigger.deltaTime;
        }
    }

    void Update()
    {
        if (enemiesInTrigger == false&&enemyTimeOutTrigger>0.5)
        {
            door1.SetActive(false);
            door2.SetActive(false);
            door3.SetActive(false);
            door4.SetActive(false);
            door5.SetActive(false);
            door6.SetActive(false);
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
                    door4.SetActive(true);
                    door5.SetActive(true);
                    door6.SetActive(true);
                    triggerActivated = true;
                }

            }
        }


    }
}
