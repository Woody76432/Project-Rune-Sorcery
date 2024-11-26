using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemChest : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        ItemDropping.SpawnItem(collision.transform.position,collision.transform.rotation);
        Destroy(gameObject);
    }
}
