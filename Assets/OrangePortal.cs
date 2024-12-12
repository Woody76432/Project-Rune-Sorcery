using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class OrangePortal : MonoBehaviour
{
    public GameObject player;
    public int moveSpeed = 3;
    public bool move = true;
    public Rigidbody2D orangePortal;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("player");
        orangePortal = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (move == true)
        {
            orangePortal.velocity = transform.up * moveSpeed;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            GameObject target = GameObject.FindWithTag("blue_portal");
            if (target != null)
            {
                player.transform.position = target.transform.position;
                Destroy(target);
                Destroy(gameObject);
            }
        }
        else
        {
            move = false;
        }
    }
}