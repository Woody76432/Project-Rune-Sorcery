using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ekkoTimeWatch : MonoBehaviour
{
    private int playerHealth;
    private float travelCountdown = 4;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("player");
        playerHealth = Player.GetHealth();
    }

    // Update is called once per frame
    void Update()
    {
        travelCountdown -= Time.deltaTime;
        if (travelCountdown < 0)
        {
            player.transform.position = this.transform.position;
            Destroy(gameObject);
            Player.SetHealth(playerHealth);
        }
    }
}
