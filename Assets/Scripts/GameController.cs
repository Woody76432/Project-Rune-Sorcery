using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameController : MonoBehaviour
{
    //Player stats Section
    public int playerMaxHealth = 10;
    public int playerCurrentHealth = 5;
    public int playerDamage = 1;
    public float iFrames = 0;
    public float iFramesMax = 1;
    public GameObject projectile;


    // Healthbar Text stuff
    [SerializeField]
    private TMP_Text _text;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Item Healing
        if (collision.gameObject.tag == "healthitem")
        {
            PlayerHeal(5);
            Debug.Log("Current health is " + playerCurrentHealth.ToString() + " after healing.");
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag =="healthupitem")
        {
            playerMaxHealth = playerMaxHealth + 5;
            Destroy(collision.gameObject);  
        }

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
    
    // Start iFrames after being hit to prevent instant kills.
    public void iFramesStart()
    {
        iFrames = iFramesMax;
        // Timer countdown is in the update
    }



    // Damage Function
    public void Damage(int damage)
    {
        playerCurrentHealth -= damage;
        Debug.Log("Health has changed to "+playerCurrentHealth.ToString());
        if (playerCurrentHealth <= 0)
        {
            Debug.Log("Player has died after health reached 0");
            //Implement Game Over Screen;
            _text.text = "GAME OVER SCREEN";
        }
    }

    // Heal Function
    public void PlayerHeal(int health)
    {
        playerCurrentHealth += health;
        Debug.Log("Health has changed to "+playerCurrentHealth.ToString());
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



        // Update Health text

        _text.text = "Health : " + playerCurrentHealth.ToString()+" / "+playerMaxHealth.ToString();

        // Fire Projectile
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectile, transform.position, transform.rotation);
        }




    }
}
