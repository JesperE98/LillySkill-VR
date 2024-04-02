using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using Jesper.InterviewAnswersAndQuestions.Data;
using Jesper.InterviewQuestionsList.Data;

namespace Jesper.GameSettings.Data
{
    [CreateAssetMenu(fileName = "GameSettingsData", menuName = "ScriptableObjects/GameSettingsScriptableObject", order = 0)]
    public class GameSettingsScriptableObject : ScriptableObject
    {

        public float playerHighScore;
        [SerializeField]
        private LoadedScene loadedScene;

        public LoadedScene GetScene
        {
            get
            {
                return loadedScene;
            }
            set
            {
                loadedScene = value;
            }
        }

        /// <summary>
        /// Saves the players current highscore.
        /// </summary>
        public float PlayerHighScore 
        { 
            get
            { 
                return playerHighScore;
            } 
            set
            { 
                
                playerHighScore = value; 
            } 
        }

        /// <summary>
        /// Changes the quality level to URP Performant
        /// </summary>
        public virtual void PerformantQuality()
        {
            QualitySettings.SetQualityLevel(0);
        }

        /// <summary>
        /// Changes the quality level to URP Balanced
        /// </summary>
        protected internal void BalancedQuality()
        {
            QualitySettings.SetQualityLevel(1);
        }

        /// <summary>
        /// Changes the quality level to URP High Fidelity
        /// </summary>
        protected internal void HighFidelityQuality()
        {
            QualitySettings.SetQualityLevel(2);
        }

        /// <summary>
        /// Enum value for each individual scene (MainMenu, Office, Tutorial).
        /// </summary>
        public enum LoadedScene
        {
            MainMenu,
            Office,
            Tutorial
        }
    }
}
