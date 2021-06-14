using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSky : MonoBehaviour
{
    //Initialises variables
    public float rotateSpeed = 1.1f;
 
    // Update is called once per frame
    // Just here for the skybox animation
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * rotateSpeed);
    }
}
