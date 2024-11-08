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
                    // Instantiate 3 different arrows at the different projectile spawn positions
                    //Instantiate(arrows, projectileSpawnLocation.transform.position, projectileSpawnLocation.transform.rotation);
                    Debug.Log("Fire Arrows");
                    break;
                case "rifle":
                    // Instantiate 1 laser at projectile spawn location
                    Instantiate(lasers, projectileSpawnLocation.transform.position, projectileSpawnLocation.transform.rotation);
                    Debug.Log("Fire Arrows");
                    break;
                case "rocket launcher":
                    //Instantiate 1 rocket projectile that can go through multiple enemies and flys erratically before deleting itself
                    Instantiate(rockets, projectileSpawnLocation.transform.position, projectileSpawnLocation.transform.rotation);
                    Debug.Log("fire Rockets");
                    break;
            }
        }
        // Determine what kind of weapon the player should fire based on a string that can be updated by the weapon through a function

    }
}
