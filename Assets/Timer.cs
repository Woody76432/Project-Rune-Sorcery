using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{

    [SerializeField]
    private TMP_Text _text;     

    float timer = 0f;
    int minTimer = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;
        if (timer >= 60)
        {
            timer = 0;
            minTimer++;
            Player.SetScore(1000);
        }
        // String interpolation, Prepend it with a $"text{anyvariable}xy" and it will add in any variable, similar to all the "lorem ipsum{0} dolco"+var kinda stuff 
        _text.text = $"Timer - {minTimer} : {timer:#00.00}";

    }
}
