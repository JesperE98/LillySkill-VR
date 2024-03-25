using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Jesper.GameSettings.Data;

namespace JespersCode
{
    public class SceneHandler : MonoBehaviour
    {
        private GameManager _gameManager;
        private Renderer _fadeScreen;
        public bool _loopDone = false;

        [SerializeField]
        private GameSettingsScriptableObject _gameSettings;

        private void Awake()
        {

            if (_gameSettings.LoadedScene != "Main Menu")
            {
                _gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
            }
            _fadeScreen = GameObject.Find("FadeScreen").GetComponent<Renderer>();
        }
        private void Start()
        {
            
            StartCoroutine(FadeInRoutine(true));
        }

        /// <summary>
        /// Loads the Start Menu Scene.
        /// </summary>
        public void LoadScene(string sceneName)
        {
            StartCoroutine(LoadLevelAsync(true, sceneName));
        }

        /// <summary>
        /// Resets current active scene.
        /// </summary>
        public void ResetCurrentScene(string sceneName)
        {
            _gameManager.DefaultValues();
            StartCoroutine(LoadLevelAsync(true, sceneName));
        }

        /// <summary>
        /// Quits the application.
        /// </summary>
        public void QuitApplication()
        {
            StartCoroutine(QuitApplication(true));
        }

        private IEnumerator FadeInRoutine(bool fadeAway)
        {
            // Fade from opaque to transparent
            if (fadeAway)
            {
                // Loop over 3 seconds backwards
                for (float i = 1; i >= 0; i -= Time.deltaTime)
                {
                    _fadeScreen.material.color = new Color(0, 0, 0, i);
                    yield return null;
                }
            }

            if (_gameSettings.LoadedScene != "Main Menu")
            {
                _gameManager.FadeInComplete = true;
            }
        }

        /// <summary>
        /// IEnumerator which loads a new scene.
        /// </summary>
        /// <param name="fadeAway"></param>
        /// <param name="sceneName"></param>
        /// <returns></returns>
        private IEnumerator LoadLevelAsync(bool fadeAway, string sceneName)
        {
            // Fade from transparent to opaque
            if (fadeAway == true)
            {
                // Loop over 4 seconds forwards
                for (float i = 0; i <= 1; i += Time.deltaTime)
                {
                    _fadeScreen.material.color = new Color(0, 0, 0, i);
                    yield return null;
                }
            }

            _gameSettings.LoadedScene = sceneName;
            AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName);

            while (!asyncLoad.isDone)
            {
                yield return null;
            }

            if (_gameSettings.LoadedScene != "Main Menu")
            {
                _gameManager.FadeOutComplete = true;
            }
        }

        private IEnumerator QuitApplication(bool fadeAway)
        {
            if (fadeAway == true)
            {
                for (float i = 0; i <= 1; i += Time.deltaTime)
                {
                    _fadeScreen.material.color = new Color(0, 0, 0, i);
                    yield return null;
                }
            }

            Application.Quit();
        }
    }
}

