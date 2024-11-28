using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISwapper : MonoBehaviour
{
    public GameObject playerUI;
    public GameObject deadUI;

    // Update is called once per frame
    void Update()
    {
        if (Player.GetHealth()<=0)
        {
            playerUI.SetActive(false);
            deadUI.SetActive(true);
        }
    }
}
