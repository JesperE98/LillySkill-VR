using JesperScriptableObject;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.UI;

namespace JespersCode
{
    public class FeedbackScreenTextUpdate : MonoBehaviour
    {
        private GameManager gameManager;
        private TMP_Text answerText;

        [SerializeField]
        private GameSettingsScriptableObject m_GameSettingsScriptableObject;
        [SerializeField]
        private FeedbackTextScriptableObject m_FeedbackTextScriptableObject;


        private void Awake()
        {
            gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
            answerText = GetComponent<TMP_Text>();
        }

        private void Start()
        {
            FeedbackPageText();
        }

        private void FeedbackPageText()
        {
            if (gameManager.InterviewAreActive == false)
            {
                if (gameManager.PlayerScore < 7)
                {
                    answerText.text = "Du fick bara " + gameManager.PlayerScore + " po�ng.\n\n " + m_FeedbackTextScriptableObject.m_BadResultFeedbackText;
                }
                else if (gameManager.PlayerScore > 7 || gameManager.PlayerScore < 14)
                {
                    answerText.text = "Du fick " + gameManager.PlayerScore + " po�ng. Bra jobbat! Men h�r har du n�got att fundera �ver.\n\n" +
                        m_FeedbackTextScriptableObject.m_AverageResultFeedbackText;
                }
                else if (gameManager.PlayerScore > 14)
                {
                    answerText.text = "Du fick " + gameManager.PlayerScore + " po�ng! Grymt jobbat! Du kommer acea din intervju!\n\n" +
                        m_FeedbackTextScriptableObject.m_GoodResultFeedbackText;
                }
            }
        }
    }
}

