using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalToNextLevel : MonoBehaviour
{
    public Transform player;
    public Transform nextLevel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="player")
        {
            player.transform.position=nextLevel.transform.position;
        }
    }
}
