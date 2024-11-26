using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class ItemDropping : MonoBehaviour
{
    // List all the declarations for all the different items here, then add an if statement for their item.
    // Need to make one public gameobject to assign it in the inspector, then a static one so the function can be called from other classes.

    public GameObject healthUpItem;
    public GameObject healingItem;
    public GameObject speedUpItem;
    public GameObject bow;
    public GameObject rifle;
    public GameObject rocketL;
    public GameObject scoreCoin;

    public static GameObject staticHealthUpItem;
    public static GameObject staticHealingItem;
    public static GameObject staticSpeedUpItem;
    public static GameObject staticBow;
    public static GameObject staticRifle;
    public static GameObject staticRocketL;
    public static GameObject staticscoreCoin;

    // I HONESTLY DO NOT KNOW WHY BUT FOR SOME GODDAMN REASON YOU CANT USE A STATIC GAME OBJECT IN THE INSPECTOR EVEN IF ITS PUBLIC SO YOU HAVE TO ON START ASSIGN THE STATIC VERSION OF THE GAMEOBJECT WITH THE ASSIGNED PUBLIC ONE
    // KILL ME
    public void Start()
    {   
        staticHealthUpItem = healthUpItem;
        staticHealingItem = healingItem;
        staticSpeedUpItem = speedUpItem;
        staticBow = bow;
        staticRifle = rifle;
        staticRocketL = rocketL;

    }

    public static void SpawnItem(Vector3 transform, Quaternion rotation)
    {
        int randItem = Random.Range(0, 7);
        Debug.Log($"the random number is{randItem})");

        if (randItem==1)
        {
            Instantiate(staticHealthUpItem, transform, rotation);
        }

        if (randItem==2) 
        {
            Instantiate(staticHealingItem, transform, rotation);
        }
        if (randItem == 3)
        {
            Instantiate(staticSpeedUpItem, transform, rotation);
        }
        if (randItem==4)
        {
            Instantiate(staticBow, transform, rotation);
        }
        if (randItem==5)
        {
            Instantiate(staticRifle, transform, rotation);
        }
        if (randItem==6)
        {
            Instantiate(staticRocketL, transform, rotation);
        }
    }

}
