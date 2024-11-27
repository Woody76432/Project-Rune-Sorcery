using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTowardsPlayer : MonoBehaviour
{
    public GameObject player;
    public Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("player");
        playerTransform = player.transform;
    }

    // Update is called once per frame
    void Update()
    {
        // Repurposed From rotate to cursor
        // Trigonometry to calculate the difference between where the mouse is to where the player is
        Vector3 rotationDifference = this.transform.position - player.transform.position;
        float rotationZ = Mathf.Atan2(rotationDifference.y, rotationDifference.x) * Mathf.Rad2Deg;
        //Rotates the enemy to follow the rotationZ, the 2 floats would be for 3D
        //Plus 90 to change the orientation centering
        this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);
    }
}

