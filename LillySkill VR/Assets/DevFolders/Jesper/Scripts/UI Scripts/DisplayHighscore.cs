using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Jesper.GameSettings.Data;

public class DisplayHighscore : MonoBehaviour
{
    [SerializeField]
    private GameSettingsScriptableObject _gameSettings;

    private TMP_Text _text;
    // Start is called before the first frame update
    void Awake()
    {
        _text = GetComponent<TMP_Text>();
    }

    private void Start()
    {
        _text.text = _gameSettings.PlayerHighScore.ToString();
    }
}
