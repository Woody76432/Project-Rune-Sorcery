using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class ItemDropping : MonoBehaviour
{
    // List all the declarations for all the different items here, then add an if statement for their item.

    public GameObject healthUpItem;
    public GameObject healingItem;
    public static GameObject staticHealthUpItem;
    public static GameObject staticHealingItem; 
    // I HONESTLY DO NOT KNOW WHY BUT FOR SOME GODDAMN REASON YOU CANT USE A STATIC GAME OBJECT IN THE INSPECTOR EVEN IF ITS PUBLIC SO YOU HAVE TO ON START ASSIGN THE STATIC VERSION OF THE GAMEOBJECT WITH THE ASSIGNED PUBLIC ONE
    // KILL ME
    public void Start()
    {
        staticHealthUpItem = healthUpItem;
        staticHealingItem = healingItem;
    }

    public static void SpawnItem(Vector3 transform, Quaternion rotation)
    {
        int randItem = Random.Range(0, 10);
        Debug.Log($"the random number is{randItem})");

        if (randItem==1)
        {
            Instantiate(staticHealthUpItem, transform, rotation);
        }

        if (randItem==2) 
        {
            Instantiate(staticHealingItem, transform, rotation);
        }
    }

}
