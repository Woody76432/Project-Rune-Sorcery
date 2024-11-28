using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;



public class returnToMenuTimer : MonoBehaviour
{
    private float menuTimer = 10;

    [SerializeField]
    private TMP_Text _text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _text.text = $"Returning to Menu in - {menuTimer:#00.00}";

        menuTimer -= Time.deltaTime;  
        if( menuTimer < 0 )
        {
            SceneManager.LoadScene("StartMenu");
        }
    }
}
