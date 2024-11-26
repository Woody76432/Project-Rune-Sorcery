using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCoin : MonoBehaviour
{
    public GameObject coin;
    private int angleY = 0;
    float coinTimer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        coinTimer = coinTimer + Time.deltaTime*1;
        if (coinTimer >= 0.02f)
        {
            angleY += 5;
            coin.transform.Rotate(0, angleY, 0);
            angleY = 0;
            coinTimer = 0.0f;
        }
        
    }
    public void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.tag=="player")
        {
            Player.SetScore(100);
            Destroy(coin);
        }
        
    }
}
