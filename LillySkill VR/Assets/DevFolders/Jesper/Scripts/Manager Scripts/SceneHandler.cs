using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using JesperScriptableObject;

namespace JespersCode
{
    public class SceneHandler : MonoBehaviour
    {
        [SerializeField]
        private GameSettingsScriptableObject m_GameSettingsScriptableObject;

        private GameManager gameManager;
        private int sceneIndex;

        private void Awake()
        {
            gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        }

        /// <summary>
        /// Loads the Start Menu Scene.
        /// </summary>
        public void LoadStartMenuScene ()
        {
            sceneIndex = 0;
            m_GameSettingsScriptableObject.LoadedScene = sceneIndex;
            
            SceneManager.LoadScene(m_GameSettingsScriptableObject.LoadedScene);
        }

        /// <summary>
        /// Loads the Main Interview Mode Scene.
        /// </summary>
        public void LoadMainModeScene()
        {
            sceneIndex = 1;
            m_GameSettingsScriptableObject.LoadedScene = sceneIndex;

            SceneManager.LoadScene(m_GameSettingsScriptableObject.LoadedScene);
        }

        /// <summary>
        /// Loads the Tutorial scene with the tutorial video.
        /// </summary>
        public void LoadTutorialScene()
        {
            sceneIndex = 2;
            m_GameSettingsScriptableObject.LoadedScene = sceneIndex;

            SceneManager.LoadScene(m_GameSettingsScriptableObject.LoadedScene);
        }

        /// <summary>
        /// Loads the Easy Mode Exercise Scene.
        /// </summary>
        public void LoadExercise1Scene()
        {
            sceneIndex = 0;
            m_GameSettingsScriptableObject.LoadedScene = sceneIndex;

            SceneManager.LoadScene(m_GameSettingsScriptableObject.LoadedScene);
        }

        /// <summary>
        /// Loads the Medium Mode Exercise Scene.
        /// </summary>
        public void LoadExercise2Scene()
        {
            sceneIndex = 4;
            m_GameSettingsScriptableObject.LoadedScene = sceneIndex;

            SceneManager.LoadScene(m_GameSettingsScriptableObject.LoadedScene);
        }

        /// <summary>
        /// Loads the Hard Mode Exercise Scene.
        /// </summary>
        public void LoadExercise3Scene()
        {
            sceneIndex = 5;
            m_GameSettingsScriptableObject.LoadedScene = sceneIndex;

            SceneManager.LoadScene(m_GameSettingsScriptableObject.LoadedScene);
        }

        /// <summary>
        /// Quits the application.
        /// </summary>
        public void QuitApplciation()
        {
            Application.Quit();
        }

        public void ResetCurrentScene()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            gameManager.DefaultValues();
        }
    }
}

