using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JesperScriptableObject
{
    [CreateAssetMenu(fileName = "GameSettingsData", menuName = "ScriptableObjects/GameSettingsScriptableObject", order = 0)]
    public class GameSettingsScriptableObject : ScriptableObject
    {

        public bool defaultMode, lowGraphicsPreset, mediumGraphicPreset, highGraphicPreset;
        public int playerHighScore, loadedScene;


        /// <summary>
        /// Gets and sets bool value for initiating Easy Mode interview.
        /// </summary>
        public bool DefaultMode { get { return defaultMode; } set { defaultMode = value; } }

        ///// <summary>
        ///// Gets and sets bool value for initiating Medium Mode interview.
        ///// </summary>
        //public bool MediumMode { get { return mediumMode; } set { mediumMode = value; } }

        ///// <summary>
        ///// Gets and sets bool value for initiating Hard Mode interview.
        ///// </summary>
        //public bool HardMode { get { return hardMode; } set { lowGraphicsPreset = value; } }
        public bool LowGraphicsPreset { get { return lowGraphicsPreset; } set { lowGraphicsPreset = value; } }
        public bool MediumGraphicPreset { get { return mediumGraphicPreset; } set { mediumGraphicPreset = value; } }
        public bool HighGraphicPreset { get { return highGraphicPreset; } set { highGraphicPreset = value; } }

        /// <summary>
        /// Gets and sets int value for each individual scene and what Game mode it should be.
        /// </summary>
        public int LoadedScene { get { return loadedScene; } set { loadedScene = value; } }

        /// <summary>
        /// Saves the players current highscore.
        /// </summary>
        public int PlayerHighScore { get { return playerHighScore; } set { playerHighScore = value; } }
    }
}
