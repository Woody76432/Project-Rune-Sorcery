using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class bowWeaponChanger : MonoBehaviour
{
    public GameObject rocketLauncher;
    public GameObject rifle;
    public GameObject bow;
    public float timerToPickup = 0.5f;

    // To add more weapons just change the name of the game object, script and what its destroying and swapping to !
    private void Update()
    {
        timerToPickup -= Time.deltaTime;
    }

    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (timerToPickup<0)
        {
            if (collision.gameObject.tag == "player")
            {

                switch (ProSpawn.GetWeaponString())
                {
                    case "rifle":
                        Instantiate(rifle, gameObject.transform.position, gameObject.transform.rotation);
                        break;
                    case "rocket launcher":
                        Instantiate(rocketLauncher, gameObject.transform.position, gameObject.transform.rotation);
                        break;
                }

                ProSpawn.SetWeaponString("bow");
                Destroy(bow);

            }
        }
    }
}
