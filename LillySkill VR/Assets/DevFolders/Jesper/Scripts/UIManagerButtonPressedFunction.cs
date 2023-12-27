using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManagerButtonPressedFunction : MonoBehaviour
{
    private UIManager uiManager;


    void Awake()
    {
        uiManager = GameObject.Find("UIManager").GetComponent<UIManager>();
    }

    public void UIButtonPress()
    {
        uiManager.UIButtonPressed();
    }
}
