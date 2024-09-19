using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abilities : MonoBehaviour
{
    // Set to whatever the position of "Entirely off the ability icon" is, anchored to ability icons so pos X and Y are at 0 for the middle.
    private float ability1Cooldown = -75f;
    private float ability2Cooldown = -75f;
    private float ability3Cooldown = -75f;

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
        // Ability Q
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
        // Ability E

        // Ability F

        // Move the masks into its pos X of cooldown
        if (ability1Cooldown!= -75f)
        {
            ability1Mask.GetComponent<RectTransform>().anchoredPosition = new Vector2(0f, ability1Cooldown);
            ability1Cooldown -= (Time.deltaTime*10);
            if (ability1Cooldown < -75f)
            {
                ability1Cooldown = -75f;
            }
        }

        if (ability2Cooldown != -75f)
        {
            ability2Mask.GetComponent<RectTransform>().anchoredPosition = new Vector2(0f, ability2Cooldown);
            ability2Cooldown -= (Time.deltaTime * 5);
            if (ability2Cooldown < -75f)
            {
                ability2Cooldown = -75f;
            }
        }

        if (ability3Cooldown != -75f)
        {
            ability3Mask.GetComponent<RectTransform>().anchoredPosition = new Vector2(0f, ability3Cooldown);
            ability3Cooldown -= (Time.deltaTime * 5);
            if (ability3Cooldown < -75f)
            {
                ability3Cooldown = -75f;
            }
        }

    }
}
