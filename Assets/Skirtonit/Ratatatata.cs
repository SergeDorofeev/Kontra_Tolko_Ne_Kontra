using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ratatatata : MonoBehaviour
{
    public Transform Cumry;
    // Update is called once per frame
    void Update()
    {
        transform.localEulerAngles = new Vector3(0, Cumry.localEulerAngles.y, Cumry.localEulerAngles.z);
    }
}
