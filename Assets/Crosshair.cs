using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimAndFire : MonoBehaviour
{
    private Vector3 cursor;
    public GameObject crosshairOverlay;
    public GameObject player;
    

    // Start is called before the first frame update
    void Start()
    {
        // Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        // This gets the X and Y for the mouse cursor in the screen of the Camera this script is on, then places this into the temporary variable "cursor" before being copied to the "crosshairOverlay" transform
        cursor = transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
        crosshairOverlay.transform.position = new Vector2(cursor.x,cursor.y);


        // Trigonometry to calculate the difference between where the mouse is to where the player is
        Vector3 rotationDifference = cursor - player.transform.position;
        float rotationZ = Mathf.Atan2(rotationDifference.y, rotationDifference.x)*Mathf.Rad2Deg;

        //Rotates the player to follow the rotationZ, the 2 floats would be for 3D
        //Plus 270 to change the orientation centreing
        player.transform.rotation = Quaternion.Euler(0.0f,0.0f,rotationZ+270);

    }


}
