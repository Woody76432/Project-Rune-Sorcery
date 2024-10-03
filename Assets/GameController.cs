using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{
    //Player stats Section
    public  int playerMaxHealth = 10;
    public  int playerCurrentHealth = 5;
    public  int playerDamage = 1;
    public  float iFrames = 0;
    public  float iFramesMax = 1;
    public GameObject projectile;
    public static int score = 0;


    // Healthbar Text stuff
    [SerializeField]
    private TMP_Text _text;


    private void OnCollisionEnter2D(Collision2D collision)
    {

        //--------------------------------------------------------------------------Item Healing---------------------------------------------------------------------------//


        // Item Healing
        if (collision.gameObject.tag == "healthitem")
        {
            if (playerCurrentHealth != playerMaxHealth)
            {
                Destroy(collision.gameObject);
                PlayerHeal(5);
                Debug.Log("Healed Player");
            }
            else
            {
                Debug.Log("Health too far, cant heal");
            }
        }
        //--------------------------------------------------------------------------Max Health up item---------------------------------------------------------------------------//


        // Health up Item
        if (collision.gameObject.tag =="healthupitem")
        {
            playerMaxHealth = playerMaxHealth + 5;
            Destroy(collision.gameObject);
            SetScore(50);
        }

        //--------------------------------------------------------------------------Enemy Melee damage---------------------------------------------------------------------------//

        // Enemy Damage on Collision
        if (collision.gameObject.tag == "enemy")
        {
            if (iFrames==0)
            {
                //Damage();
                iFramesStart();

                // For debugging the Health and Damage
                Debug.Log("After damage, iFrames started and the Health is " + playerCurrentHealth.ToString());

                //Default to 1 damage
                Damage(1);
            }
        }
    }

    //--------------------------------------------------------------------------iFramesStart Function---------------------------------------------------------------------------//


    // Start iFrames after being hit to prevent instant kills.
    public void iFramesStart()
    {
        iFrames = iFramesMax;
        // Timer countdown is in the update
    }

    //--------------------------------------------------------------------------Damage Function---------------------------------------------------------------------------//


    // Damage Function
    public void Damage(int damage)
    {
        playerCurrentHealth -= damage;
        Debug.Log("Health has changed to "+playerCurrentHealth.ToString());
        SetScore(-50);
        if (playerCurrentHealth <= 0)
        {
            Debug.Log("Player has died after health reached 0");
            //Implement Game Over Screen;
            _text.text = "GAME OVER SCREEN";
        }
    }


    //--------------------------------------------------------------------------PlayerHeal Function---------------------------------------------------------------------------//

    // Heal Function
    public void PlayerHeal(int health)
    {
        if ((playerCurrentHealth != playerMaxHealth) || ((playerCurrentHealth += health) != playerMaxHealth))
        {
            playerCurrentHealth += health;
            if (playerCurrentHealth > playerMaxHealth)
            {
                playerCurrentHealth = playerMaxHealth;
            }
        }



        Debug.Log("Health has changed to "+playerCurrentHealth.ToString());
    }
    public static void SetScore(int scoreToAdd)
    {
        score += scoreToAdd;
    }
    public static int GetScore()
    {
        return score;
    }




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //--------------------------------------------------------------------------Logs and updates respawn timer---------------------------------------------------------------------------//

        // iFrames Timer
        if (iFrames!=0)
        {
            iFrames = iFrames - Time.deltaTime;
            if (iFrames < 0)
            {
                iFrames = 0;
            }
            Debug.Log("Iframe timer is "+ iFrames.ToString());
        }


        //--------------------------------------------------------------------------UI Health Text changing---------------------------------------------------------------------------//

        // Update Health text

        _text.text = "Health : " + playerCurrentHealth.ToString()+" / "+playerMaxHealth.ToString();

    }
}
