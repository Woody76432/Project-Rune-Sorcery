using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollowPlayer : MonoBehaviour
{
    public Transform player;
    private float cameraOffset = -20.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Follows Player
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, cameraOffset);
    }
}
