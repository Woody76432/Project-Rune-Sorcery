using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rifleWeaponChanger : MonoBehaviour
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
        if (timerToPickup < 0)
        {
            if (collision.gameObject.tag == "player")
            {

                switch (ProSpawn.GetWeaponString())
                {
                    case "rocket launcher":
                        Instantiate(rocketLauncher, gameObject.transform.position, gameObject.transform.rotation);
                        break;
                    case "bow":
                        Instantiate(bow, gameObject.transform.position, gameObject.transform.rotation);
                        break;
                }

                ProSpawn.SetWeaponString("rifle");
                Destroy(rifle);

            }
        }
    }
}