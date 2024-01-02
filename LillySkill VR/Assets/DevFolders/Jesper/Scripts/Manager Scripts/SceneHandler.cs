using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace JespersCode
{
    public class SceneHandler : MonoBehaviour
    {
        protected SceneHandler sceneHandler;
        protected GameManager gameManager;

        private void Awake()
        {
            if (sceneHandler == null)
            {
                sceneHandler = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }

            gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        }

        /// <summary>
        /// Loads the Start Menu Scene.
        /// </summary>
        /// <param name="sceneIndex"></param>
        public void LoadStartMenuScene (int sceneIndex)
        {
            sceneIndex = 0;
            gameManager.LoadedScene = sceneIndex;
            
            SceneManager.LoadScene(gameManager.LoadedScene);
        }

        /// <summary>
        /// Loads the Main Interview Mode Scene.
        /// </summary>
        /// <param name="sceneIndex"></param>
        public void LoadMainModeScene(int sceneIndex)
        {
            sceneIndex = 1;
            gameManager.LoadedScene = sceneIndex;

            SceneManager.LoadScene(gameManager.LoadedScene);
        }

        /// <summary>
        /// Loads the Tutorial scene with the tutorial video.
        /// </summary>
        /// <param name="sceneIndex"></param>
        public void LoadTutorialScene(int sceneIndex)
        {
            sceneIndex = 2;
            gameManager.LoadedScene = sceneIndex;

            SceneManager.LoadScene(gameManager.LoadedScene);
        }

        /// <summary>
        /// Loads the Easy Mode Exercise Scene.
        /// </summary>
        /// <param name="sceneIndex"></param>
        public void LoadExercise1Scene(int sceneIndex)
        {
            sceneIndex = 3;
            gameManager.LoadedScene = sceneIndex;

            SceneManager.LoadScene(gameManager.LoadedScene);
        }

        /// <summary>
        /// Loads the Medium Mode Exercise Scene.
        /// </summary>
        /// <param name="sceneIndex"></param>
        public void LoadExercise2Scene(int sceneIndex)
        {
            sceneIndex = 4;
            gameManager.LoadedScene = sceneIndex;

            SceneManager.LoadScene(gameManager.LoadedScene);
        }

        /// <summary>
        /// Loads the Hard Mode Exercise Scene.
        /// </summary>
        /// <param name="sceneIndex"></param>
        public void LoadExercise3Scene(int sceneIndex)
        {
            sceneIndex = 5;
            gameManager.LoadedScene = sceneIndex;

            SceneManager.LoadScene(gameManager.LoadedScene);
        }

        /// <summary>
        /// Quits the application.
        /// </summary>
        public void QuitApplciation()
        {
            Application.Quit();
        }
    }
}

