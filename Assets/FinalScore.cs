using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class FinalScore : MonoBehaviour
{

    [SerializeField]
    private TMP_Text _text;

    // Start is called before the first frame update
    void Start()
    {
        _text.text = $"Your Final Score Was - {Player.GetScore()}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
