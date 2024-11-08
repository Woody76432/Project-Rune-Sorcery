using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bowWeaponChanger : MonoBehaviour
{
    public GameObject bow;

    // To add more weapons just change the name of the game object, script and what its destroying and swapping to !
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag =="player")
        {
            ProSpawn.SetWeaponString("bow");
            Destroy(bow);
        }

    }
}
