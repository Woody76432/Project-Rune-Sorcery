using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTowardsCursor : MonoBehaviour
{
    private Vector3 cursor;
    public Camera camera;


    // Start is called before the first frame update
    void Start()
    {
        // Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        // This gets the X and Y for the mouse cursor in the screen of the Camera this script is on, then places this into the variable "cursor"
        cursor = camera.ScreenToWorldPoint(Input.mousePosition);

        // Trigonometry to calculate the difference between where the mouse is to where the player is
        Vector3 rotationDifference = cursor - this.transform.position;
        float rotationZ = Mathf.Atan2(rotationDifference.y, rotationDifference.x) * Mathf.Rad2Deg;

        //Rotates the player to follow the rotationZ, the 2 floats would be for 3D
        //Plus 270 to change the orientation centreing
        this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ + 270);
    }
}


