using TMPro;
using UnityEngine;
using Jesper.GameSettings.Data;
using Jesper.FeedbackText.Data;

namespace Jesper.Collection
{
    public class FeedbackScreenTextUpdate : MonoBehaviour
    {
        // Måste se till så att feedbacken eller något annat script kan räökna ut den procentuella mängden av rätt svar och basera feedbacken baserat på det.
        
        private GameManager _gameManager;
        private TMP_Text _answerText;

        [SerializeField]
        private GameSettingsScriptableObject _gameSettings;
        [SerializeField]
        private FeedbackTextScriptableObject _feedbackText;
        [SerializeField]
        private float percentageCalculator;


        private void Awake()
        {
            _gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
            _answerText = GetComponent<TMP_Text>();
        }

        private void Start()
        {
            percentageCalculator = _gameManager.PlayerScore / _gameManager.MaxScore;

            FeedbackPageText();
        }

        private void FeedbackPageText()
        {
            if (percentageCalculator < 0.4f)
            {
                _answerText.text = "Du fick bara " + _gameManager.PlayerScore + " poäng.\n\n " + _feedbackText.m_BadResultFeedbackText;
            }
            else if (percentageCalculator > 0.4f || percentageCalculator < 0.8f)
            {
                _answerText.text = "Du fick " + _gameManager.PlayerScore + " poäng. Bra jobbat! Men här har du något att fundera över.\n\n" +
                    _feedbackText.m_AverageResultFeedbackText;
            }
            else if (percentageCalculator > 0.8f)
            {
                _answerText.text = "Du fick " + _gameManager.PlayerScore + " poäng! Grymt jobbat! Du kommer acea din intervju!\n\n" +
                    _feedbackText.m_GoodResultFeedbackText;
            }
        }
    }
}

