using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManagerButtonFunctions : MonoBehaviour
{
    private UIManager uiManager;
    private GameManager gameManager;

    void Awake()
    {
        uiManager = GameObject.Find("UIManager").GetComponent<UIManager>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    public void UsedWorstAnswerButton()
    {
        gameManager.UsedWorstAnswer = true;
        uiManager.UIButtonPressed();
    }

    public void UsedBadAnswerButton()
    {
        gameManager.UsedBadAnswer = true;
        uiManager.UIButtonPressed();
    }

    public void UsedAverageAnswerButton()
    {
        gameManager.UsedAverageAnswer = true;
        uiManager.UIButtonPressed();
    }

    public void UsedGoodAnswerButton()
    {
        gameManager.UsedGoodAnswer = true;
        uiManager.UIButtonPressed();
    }

    public void UsedBestAnswerButton()
    {
        gameManager.UsedBestAnswer = true;
        uiManager.UIButtonPressed();
    }
}
