using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDropping : MonoBehaviour
{
    // List all the declarations for all the different items here, then add an if statement for their item.

    public static GameObject healthUpItem;
    public static GameObject healingItem;



    public static void SpawnItem(Transform transform, Transform rotation)
    {
        int randItem = Random.Range(0, 1);
           
        if (randItem==0)
        {
            Instantiate(healthUpItem, transform, rotation);
        }
    }
}
