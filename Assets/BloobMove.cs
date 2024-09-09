using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloobMove : MonoBehaviour
{
    public Rigidbody2D bloobBody;
    int rndint = 0;
    public float moveCooldown = 0;
    float rndinttime = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rndinttime==0)
        {
            rndinttime = Random.Range(0, 3);
        }
        
        if ( moveCooldown<rndinttime)
        {
            moveCooldown = moveCooldown+Time.deltaTime;
        }
        else
        {

            rndint = Random.Range(0, 5);
            if (rndint == 1)
            {
                bloobBody.velocity = Vector2.up * 5;
            }
            if (rndint == 2)
            {
                bloobBody.velocity = Vector2.right * 5;
            }
            if (rndint == 3)
            {
                bloobBody.velocity = Vector2.left * 5;
            }
            if (rndint == 4)
            {
                bloobBody.velocity = Vector2.down * 5;
            }
            moveCooldown = 0;
            rndinttime = 0;
        }
    }
 
}
