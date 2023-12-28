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
        Debug.Log("Hi Worst Asnwer");
        gameManager.UsedWorstAnswer = true;
        uiManager.UIButtonPressed();
    }

    public void UsedBadAnswerButton()
    {
        Debug.Log("Hi Bad Asnwer");

        gameManager.UsedBadAnswer = true;
        uiManager.UIButtonPressed();
    }

    public void UsedAverageAnswerButton()
    {
        Debug.Log("Hi Average Asnwer");
        gameManager.UsedAverageAnswer = true;
        uiManager.UIButtonPressed();
    }

    public void UsedGoodAnswerButton()
    {
        Debug.Log("Hi Good Asnwer");
        gameManager.UsedGoodAnswer = true;
        uiManager.UIButtonPressed();
    }

    public void UsedBestAnswerButton()
    {
        Debug.Log("Hi Best Asnwer");
        gameManager.UsedBestAnswer = true;
        uiManager.UIButtonPressed();
    }

    public void NextPageButton()
    {
        Destroy(gameObject);

        GameObject newUIPrefabCopy = Instantiate(uiManager.UIPrefabs[2]);
    }
}
