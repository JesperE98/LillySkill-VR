using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.UI;
using Jesper.GameSettings.Data;
using Jesper.FeedbackText.Data;

namespace Jesper.Collection
{
    public class FeedbackScreenTextUpdate : MonoBehaviour
    {
        private GameManager _gameManager;
        private TMP_Text _answerText;

        [SerializeField]
        private GameSettingsScriptableObject _gameSettings;
        [SerializeField]
        private FeedbackTextScriptableObject _feedbackText;


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
                _answerText.text = "Du fick bara " + _gameManager.PlayerScore + " po�ng.\n\n " + _feedbackText.m_BadResultFeedbackText;
            }
            else if (_gameManager.PlayerScore > 7 || _gameManager.PlayerScore < 14)
            {
                _answerText.text = "Du fick " + _gameManager.PlayerScore + " po�ng. Bra jobbat! Men h�r har du n�got att fundera �ver.\n\n" +
                    _feedbackText.m_AverageResultFeedbackText;
            }
            else if (_gameManager.PlayerScore > 14)
            {
                _answerText.text = "Du fick " + _gameManager.PlayerScore + " po�ng! Grymt jobbat! Du kommer acea din intervju!\n\n" +
                    _feedbackText.m_GoodResultFeedbackText;
            }
        }
    }
}

