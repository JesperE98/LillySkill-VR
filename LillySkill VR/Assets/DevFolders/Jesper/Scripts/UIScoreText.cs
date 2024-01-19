using JespersCode;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class UIScoreText : MonoBehaviour
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
        if(gameManager.InterviewAreActive == false)
        {
            text.text = $"{gameManager.InterviewerInterest} / 20";
        }
    }
}
