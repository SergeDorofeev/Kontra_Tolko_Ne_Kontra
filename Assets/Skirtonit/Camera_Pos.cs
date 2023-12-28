using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Pos : MonoBehaviour
{
    public Transform Camera_pos;
    // Update is called once per frame
    void Update()
    {
        transform.position = Camera_pos.position;
    }
}
