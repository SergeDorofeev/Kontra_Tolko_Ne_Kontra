using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Igorek_Camera : MonoBehaviour
{
    public float senseX;
    public float senseY;
    public Transform Pidorasina;
    float x_rotation;
    float y_rotation;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false; // Turn off the cursor
    }

    // Update is called once per frame
    void Update()
    {
        // Get mouse unput
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * senseX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * senseY;
        y_rotation += mouseX;
        x_rotation -= mouseY;
        // Limit roitation so player cannot look too high or the opposite
        x_rotation = Mathf.Clamp(x_rotation, -90f, 90f);
        //rotate camera and Pidorasnost
        transform.rotation = Quaternion.Euler(x_rotation, y_rotation, 0);
        Pidorasina.rotation = Quaternion.Euler(0, y_rotation, 0);
    }
}
