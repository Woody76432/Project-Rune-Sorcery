using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abilities : MonoBehaviour
{
    // Set to whatever the position of "Entirely off the ability icon" is, anchored to ability icons so pos X and Y are at 0 for the middle.
    public static float ability1Cooldown = -75f;
    public static float ability2Cooldown = -75f;
    public static float ability3Cooldown = -75f;

    public static float ability1CooldownMultiplier = 10;
    public static float ability2CooldownMultiplier = 2;
    public static float ability3CooldownMultiplier = 3;

    public GameObject grenade;

    // Setters for other scripts to influence cooldown timers -----------------------------------------------------------------------------------------------------------------
    public static void SetAbility1CooldownMultiplier(int multiplier)
    {
        ability1CooldownMultiplier = multiplier;
    }
   
    public static void SetAbility2CooldownMultiplier(int multiplier)
    {
        ability2CooldownMultiplier = multiplier;
    }

    public static void SetAbility3CooldownMultiplier(int multiplier)
    {
        ability3CooldownMultiplier = multiplier;
    }


    // Getters for other scripts to check cooldowns -----------------------------------------------------------------------------------------------------------------------
    public static float GetAbility1Cooldown()
    {
        return ability1Cooldown;
    }

    public static float GetAbility2Cooldown()
    {
        return ability2Cooldown;
    }

    public static float GetAbility3Cooldown()
    {
        return ability3Cooldown;
    }
    //-------------------------------------------------------------------------------------------------------------------------------------------------------

    public GameObject ability1Mask;
    public GameObject ability2Mask;
    public GameObject ability3Mask;

    // Set the cooldown to 0, subtract time.deltatime to cooldown until it reaches 75 or over then end

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (ability1Cooldown==-75f)
            {
                ability1Cooldown = 0f;
            }
        }

        if( Input.GetKeyDown(KeyCode.E))
        {
            if (ability2Cooldown ==-75f)
            {
                ability2Cooldown = 0f;
            }
        }

        if ( Input.GetKeyDown(KeyCode.F))
        {

            if (ability3Cooldown ==-75f)
            {
                ability3Cooldown = 0f;
            }
        }
 

        // Move the masks into its posX of "cooldown" -------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        if (ability1Cooldown!= -75f)
        {
            ability1Mask.GetComponent<RectTransform>().anchoredPosition = new Vector2(0f, ability1Cooldown);
            ability1Cooldown -= (Time.deltaTime*ability1CooldownMultiplier);
            if (ability1Cooldown < -75f)
            {
                ability1Cooldown = -75f;
                Instantiate(grenade, transform.position, transform.rotation);

            }
        }

        if (ability2Cooldown != -75f)
        {
            ability2Mask.GetComponent<RectTransform>().anchoredPosition = new Vector2(0f, ability2Cooldown);
            ability2Cooldown -= (Time.deltaTime * ability2CooldownMultiplier);
            if (ability2Cooldown < -75f)
            {
                ability2Cooldown = -75f;
            }
        }

        if (ability3Cooldown != -75f)
        {
            ability3Mask.GetComponent<RectTransform>().anchoredPosition = new Vector2(0f, ability3Cooldown);
            ability3Cooldown -= (Time.deltaTime * ability3CooldownMultiplier);
            if (ability3Cooldown < -75f)
            {
                ability3Cooldown = -75f;
            }
        }
    }
}
