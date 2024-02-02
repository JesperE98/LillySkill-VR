using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace JespersCode
{
    public class SceneHandler : MonoBehaviour
    {
        //private static SceneHandler sceneHandler;
        private GameManager gameManager;

        private int sceneIndex;

        private void Awake()
        {
            //if (sceneHandler == null)
            //{
            //    sceneHandler = this;
            //    DontDestroyOnLoad(gameObject);
            //}
            //else
            //{
            //    Object.Destroy(gameObject);
            //}

            gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        }

        /// <summary>
        /// Loads the Start Menu Scene.
        /// </summary>
        /// <param name="sceneIndex"></param>
        public void LoadStartMenuScene ()
        {
            sceneIndex = 0;
            gameManager.LoadedScene = sceneIndex;
            
            SceneManager.LoadScene(gameManager.LoadedScene);
        }

        /// <summary>
        /// Loads the Main Interview Mode Scene.
        /// </summary>
        /// <param name="sceneIndex"></param>
        public void LoadMainModeScene()
        {
            sceneIndex = 1;
            gameManager.LoadedScene = sceneIndex;

            SceneManager.LoadScene(gameManager.LoadedScene);
        }

        /// <summary>
        /// Loads the Tutorial scene with the tutorial video.
        /// </summary>
        /// <param name="sceneIndex"></param>
        public void LoadTutorialScene()
        {
            sceneIndex = 2;
            gameManager.LoadedScene = sceneIndex;

            SceneManager.LoadScene(gameManager.LoadedScene);
        }

        /// <summary>
        /// Loads the Easy Mode Exercise Scene.
        /// </summary>
        /// <param name="sceneIndex"></param>
        public void LoadExercise1Scene()
        {
            sceneIndex = 0;
            gameManager.LoadedScene = sceneIndex;

            SceneManager.LoadScene(gameManager.LoadedScene);
        }

        /// <summary>
        /// Loads the Medium Mode Exercise Scene.
        /// </summary>
        /// <param name="sceneIndex"></param>
        public void LoadExercise2Scene()
        {
            sceneIndex = 4;
            gameManager.LoadedScene = sceneIndex;

            SceneManager.LoadScene(gameManager.LoadedScene);
        }

        /// <summary>
        /// Loads the Hard Mode Exercise Scene.
        /// </summary>
        /// <param name="sceneIndex"></param>
        public void LoadExercise3Scene()
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

