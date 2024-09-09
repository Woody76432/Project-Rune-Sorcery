using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloobSpawner9000 : MonoBehaviour
{
    private float spawnCooldown = 0;
    public GameObject bloob;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnCooldown < 2) 
        {
            spawnCooldown += Time.deltaTime;
        }
        if (spawnCooldown > 1) 
        {
            Instantiate(bloob,transform.position,transform.rotation);
            spawnCooldown = 0;
        }

    }
}
