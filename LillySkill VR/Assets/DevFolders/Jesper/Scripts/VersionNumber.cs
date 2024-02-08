using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class VersionNumber : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<TextMeshProUGUI>().text = "Version: " + Application.version;
    }
}
