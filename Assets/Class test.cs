using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Classtest : MonoBehaviour
{
    public Player controller;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(controller.playerCurrentHealth);
    }
}
