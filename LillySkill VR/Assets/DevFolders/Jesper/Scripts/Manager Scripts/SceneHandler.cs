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
        private GameSettingsScriptableObject m_GameSettings;
        private FadeInFadeOut m_FadeInFadeOut;
        private GameManager gameManager;
        private int sceneIndex;

        private void Awake()
        {
            if (m_GameSettings.LoadedScene != 0)
            {
                gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
            }

            m_FadeInFadeOut = GameObject.Find("FadeScreen").GetComponent<FadeInFadeOut>();
        }

        /// <summary>
        /// Loads the Start Menu Scene.
        /// </summary>
        public void LoadStartMenuScene()
        {
            sceneIndex = 0;
            m_GameSettings.LoadedScene = sceneIndex;
            m_FadeInFadeOut.StartFadeOutRoutine();

            SceneManager.LoadScene(m_GameSettings.LoadedScene);
        }

        /// <summary>
        /// Loads the Main Interview Mode Scene.
        /// </summary>
        public void LoadMainModeScene()
        {
            sceneIndex = 1;
            m_GameSettings.LoadedScene = sceneIndex;
            m_FadeInFadeOut.StartFadeOutRoutine();
            SceneManager.LoadScene(m_GameSettings.LoadedScene);
        }

        /// <summary>
        /// Loads the Tutorial scene with the tutorial video.
        /// </summary>
        public void LoadTutorialScene()
        {
            sceneIndex = 1;
            m_GameSettings.LoadedScene = sceneIndex;
            m_FadeInFadeOut.StartFadeOutRoutine();
            SceneManager.LoadScene(m_GameSettings.LoadedScene);
        }

        /// <summary>
        /// Loads the Easy Mode Exercise Scene.
        /// </summary>
        public void LoadExerciseScene()
        {
            sceneIndex = 1;
            m_GameSettings.LoadedScene = sceneIndex;
            m_FadeInFadeOut.StartFadeOutRoutine();
            SceneManager.LoadScene(m_GameSettings.LoadedScene);
        }

        /// <summary>
        /// Quits the application.
        /// </summary>
        public void QuitApplciation()
        {
            m_FadeInFadeOut.StartFadeOutRoutine();
            Application.Quit();
        }

        public void ResetCurrentScene()
        {
            m_FadeInFadeOut.StartFadeOutRoutine();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            gameManager.DefaultValues();
        }
    }
}

