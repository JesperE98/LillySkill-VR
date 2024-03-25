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
        private GameManager _gameManager;
        private TMP_Text _answerText;

        [SerializeField]
        private GameSettingsScriptableObject m_GameSettingsScriptableObject;
        [SerializeField]
        private FeedbackTextScriptableObject m_FeedbackTextScriptableObject;


        private void Awake()
        {
            _gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
            _answerText = GetComponent<TMP_Text>();
        }

        private void Start()
        {
            FeedbackPageText();
        }

        private void FeedbackPageText()
        {
            if (_gameManager.PlayerScore < 7)
            {
                _answerText.text = "Du fick bara " + _gameManager.PlayerScore + " poäng.\n\n " + m_FeedbackTextScriptableObject.m_BadResultFeedbackText;
            }
            else if (_gameManager.PlayerScore > 7 || _gameManager.PlayerScore < 14)
            {
                _answerText.text = "Du fick " + _gameManager.PlayerScore + " poäng. Bra jobbat! Men här har du något att fundera över.\n\n" +
                    m_FeedbackTextScriptableObject.m_AverageResultFeedbackText;
            }
            else if (_gameManager.PlayerScore > 14)
            {
                _answerText.text = "Du fick " + _gameManager.PlayerScore + " poäng! Grymt jobbat! Du kommer acea din intervju!\n\n" +
                    m_FeedbackTextScriptableObject.m_GoodResultFeedbackText;
            }
        }
    }
}

