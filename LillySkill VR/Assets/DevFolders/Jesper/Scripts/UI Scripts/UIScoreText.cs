using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using Jesper.GameSettings.Data;

namespace Jesper.Collection
{
    public class UIScoreText : MonoBehaviour
    {
        [SerializeField]
        private GameSettingsScriptableObject gameSettings;
        private GameManager _gameManager;
        private TMP_Text _text;

        private void Start()
        {
            switch (gameSettings.GetScene)
            {
                case GameSettingsScriptableObject.LoadedScene.Office:
                    _gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
                    break;
            }
            _text = GetComponent<TMP_Text>();
        }

        private void Update()
        {
            switch (gameSettings.GetScene)
            {
                case GameSettingsScriptableObject.LoadedScene.Office:
                    if (_gameManager.InterviewAreActive == false)
                    {
                        _text.text = $"{_gameManager.PlayerScore} / {_gameManager.MaxScore}";
                    }
                    break;
            }
        }
    }
}
