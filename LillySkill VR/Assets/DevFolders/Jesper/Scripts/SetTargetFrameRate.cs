using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTargetFrameRate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = -1;

        Application.targetFrameRate = 60;
    }
}
