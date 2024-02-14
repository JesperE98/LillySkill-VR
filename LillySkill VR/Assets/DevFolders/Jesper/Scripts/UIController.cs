using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Deriving class of class Button to act like a bridge between the CardboardReticlePointer script and the Buttons class
/// so you can interact with UI Buttons with the Raycast CardboardReticlePointer
/// </summary>
public class UIController : Button
{
    private AudioManager audioManager;
    protected override void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();
    }

    /// <summary>
    /// This method is called by the Main Camera when it starts gazing at this GameObject.
    /// </summary>
    public void OnPointerEnter()
    {
        audioManager.Play("Button hover");
    }

    /// <summary>
    /// This method is called by the Main Camera when it stops gazing at this GameObject.
    /// </summary>
    public byte OnPointerExit()
    {
        byte emptyValue = 0;
        return emptyValue;
    }

    /// <summary>
    /// This method is called by the Main Camera when it is gazing at this GameObject and the screen
    /// is touched.
    /// </summary>
    public void OnPointerClick()
    {
        onClick.Invoke();
        audioManager.Play("Button press");
    }
}