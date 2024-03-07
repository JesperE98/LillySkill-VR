using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using JesperScriptableObject;

namespace JespersCode
{
    public class UIScoreText : MonoBehaviour
    {
        private GameManager _gameManager;
        private TMP_Text _text;

        private void Start()
        {
            _gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
            _text = GetComponent<TMP_Text>();


        }

        private void FixedUpdate()
        {
            if (_gameManager.InterviewAreActive == false)
            {
                _text.text = $"{_gameManager.PlayerScore} / 20";
            }
        }
    }
}
