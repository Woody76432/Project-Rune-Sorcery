using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    //Player stats Section
    public int playerMaxHealth = 10;
    public int playerCurrentHealth = 5;
    public int playerDamage = 1;
    private float iFrames = 0;





    // Item Healing
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "healthitem")
        {
            PlayerHeal(5);
        }
        if (collision.gameObject.tag == "enemy")
        {
        
        }
    }


    // Damage Function
    public void PlayerDamage(int damage)
    {
        playerCurrentHealth -= damage;
        Debug.Log("Health has changed to {0}");
        if (playerCurrentHealth <= 0)
        {
            //Implement Game Over Screen
        }
    }

    // Heal Function
    public void PlayerHeal(int health)
    {
        playerCurrentHealth += health;
        Debug.Log("Health has changed to {0}");
        if (playerCurrentHealth > playerMaxHealth) 
        {
            playerCurrentHealth = playerMaxHealth;
        }
    }





    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
