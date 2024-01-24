using JespersCode;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIFeedbackText : MonoBehaviour
{
    private GameManager gameManager;
    private TMP_Text text;

    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        text = GetComponent<TMP_Text>();


    }

    private void FixedUpdate()
    {
        if (gameManager.InterviewAreActive == false)
        {
            if (gameManager.PlayerScore < 3)
            {
                text.text = "* You need to work on this.\n" +
                    "* You need to work on that.\n" +
                    "* And you need to work on how.";
            }
            else if (gameManager.PlayerScore > 3 && gameManager.PlayerScore < 8)
            {
                text.text = "* You need to work on how.\n" +
                "* You need to work on this.\n" +
                "* And you need to work on that.";
            }
            else if (gameManager.PlayerScore > 8)
            {
                text.text = "* You need to work on that. \n" +
                "* You need to work on how \n" +
                "* And you need to work on this";
            }
        }
    }
}
