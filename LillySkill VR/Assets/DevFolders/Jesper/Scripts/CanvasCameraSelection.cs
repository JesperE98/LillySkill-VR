using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class CanvasCameraSelection : MonoBehaviour
{
    private Canvas myCanvas;
    CameraEvent myCameraEvent;

    private void Awake()
    {
        GetComponent<Canvas>().renderMode = RenderMode.WorldSpace;
    }
}
