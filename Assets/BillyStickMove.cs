using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;

public class BillyStickMove : MonoBehaviour
{
    //Any Variables or Classes initiates here
    public Rigidbody2D player;

    //Default Speed is 1
    public float moveSpeed = 4.0f;
    float speedX,speedY;

    //Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    //Update is called once per frame
    void Update()
    {

        // Movement Stuff
        if (Input.GetKey(KeyCode.LeftShift)) 
        {
            speedX = Input.GetAxisRaw("Horizontal") * (moveSpeed*2);
            speedY = Input.GetAxisRaw("Vertical") * (moveSpeed*2);
            player.velocity = new Vector2(speedX, speedY);
        }
        else
        {
            speedX = Input.GetAxisRaw("Horizontal") * moveSpeed;
            speedY = Input.GetAxisRaw("Vertical") * moveSpeed;
            player.velocity = new Vector2(speedX, speedY);
        }
    }
}
