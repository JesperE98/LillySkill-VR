using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Jesper.Collection
{
    public class SummaryScreenTextUpdate : MonoBehaviour
    {
        private GameManager _gameManager;
        private TMP_Text _answerText;
        // Start is called before the first frame update
        void Start()
        {
            _gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
            _answerText = GetComponent<TMP_Text>();
            SummaryPageText();
        }

        private void SummaryPageText()
        {
            for (int i = 0; i < _gameManager.AnswerList.Count; i++)
            {
                _answerText.text += _gameManager.AnswerList[i] + "\n";
            }
        }
    }
}

