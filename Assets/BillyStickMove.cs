using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;

public class BillyStickMove : MonoBehaviour
{
    //Any Variables or Classes initiates here
    public Rigidbody2D player;

    //Default Speed is 1
    public static float moveSpeed = 6.50f;
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
        speedX = Input.GetAxisRaw("Horizontal") * moveSpeed;
        speedY = Input.GetAxisRaw("Vertical") * moveSpeed;
        player.velocity = new Vector2(speedX, speedY);
    }
}
