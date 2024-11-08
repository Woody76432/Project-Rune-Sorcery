using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProSpawn : MonoBehaviour
{
    public GameObject arrows;
    public GameObject lasers;
    public GameObject rockets;
    public GameObject projectileSpawnLocation;
    public GameObject arrowSpawnPosition2;
    public GameObject arrowSpawnPosition3;

    public static string weaponName = "null";

    public static string SetWeaponString(string newWeaponString)
    {
        weaponName = newWeaponString;  
        // Also returns the weapon name incase I need it later for anything
        return weaponName;
    }
    public static string GetWeaponString()
    {
        return weaponName;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)==true)
        {
            switch (weaponName)
            {
                case "null":
                    Debug.Log("Player has no weapon so cant spawn a projectile");
                    break;

                case "bow":
                    Instantiate(arrows, projectileSpawnLocation.transform.position, projectileSpawnLocation.transform.rotation);
                    Instantiate(arrows, arrowSpawnPosition2.transform.position, arrowSpawnPosition2.transform.rotation);
                    Instantiate(arrows, arrowSpawnPosition3.transform.position, arrowSpawnPosition3.transform.rotation);

                    Debug.Log("Fire Arrows");
                    break;

                case "rifle":
                    Instantiate(lasers, projectileSpawnLocation.transform.position, projectileSpawnLocation.transform.rotation);
                    Debug.Log("Fire Arrows");
                    break;

                case "rocket launcher":
                    Instantiate(rockets, projectileSpawnLocation.transform.position, projectileSpawnLocation.transform.rotation);
                    Debug.Log("fire Rockets");
                    break;
            }
        }
        // Determine what kind of weapon the player should fire based on a string that can be updated by the weapon through a function

    }
}
