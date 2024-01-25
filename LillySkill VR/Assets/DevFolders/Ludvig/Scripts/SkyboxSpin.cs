using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxSpin : MonoBehaviour
{
    [SerializeField] private float Skyboxspeed;

    // Update is called once per frame
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * Skyboxspeed);
    }
}