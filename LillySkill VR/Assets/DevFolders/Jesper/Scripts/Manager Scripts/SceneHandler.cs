using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using Jesper.GameSettings.Data;

namespace JespersCode
{
    public class SceneHandler : MonoBehaviour
    {
        private GameManager _gameManager;
        private AudioManager _audioManager;

        
        private Renderer _fadeScreen;
        public bool _loopDone = false;

        [SerializeField]
        private GameSettingsScriptableObject _gameSettings;

        private void Awake()
        {
            if (_gameSettings.GetScene != GameSettingsScriptableObject.LoadedScene.MainMenu)
            {
                _gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
                _audioManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();
            }

            _fadeScreen = GameObject.Find("FadeScreen").GetComponent<Renderer>();
        }
        private void Start()
        {
            switch (_gameSettings.GetScene)
            {
                case GameSettingsScriptableObject.LoadedScene.MainMenu:
                    StartCoroutine(FadeInRoutine(true));
                    break;

                case GameSettingsScriptableObject.LoadedScene.Office:

                    if (!_gameManager.FadeInComplete)
                    {
                        StartCoroutine(FadeInRoutine(true));
                    }
                    break;

                case GameSettingsScriptableObject.LoadedScene.Tutorial:

                    if (!_gameManager.FadeInComplete)
                    {
                        StartCoroutine(FadeInRoutine(true));
                    }
                    break;
            }
        }

        /// <summary>
        /// Loads the Start Menu Scene.
        /// </summary>
        public void LoadScene(int sceneBuildIndex)
        {
            switch (_gameSettings.GetScene)
            {
                case GameSettingsScriptableObject.LoadedScene.MainMenu:
                    StartCoroutine(LoadLevelAsync(true, sceneBuildIndex));
                    break;

                case GameSettingsScriptableObject.LoadedScene.Office:
                    StartCoroutine(LoadLevelAsync(true, sceneBuildIndex));
                    _gameManager.ResetAllValues();
                    _audioManager.ResetAllAudioValues();
                    break;
            }
        }

        /// <summary>
        /// Resets current active scene.
        /// </summary>
        public void ResetCurrentScene(int sceneBuildIndex)
        {
            _audioManager.ResetInterviewAudioData();
            _gameManager.DefaultValues();
            StartCoroutine(LoadLevelAsync(true, sceneBuildIndex));
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

            if (_gameSettings.GetScene != GameSettingsScriptableObject.LoadedScene.MainMenu)
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
        private IEnumerator LoadLevelAsync(bool fadeAway, int sceneBuildIndex)
        {
            _gameSettings.GetScene = (GameSettingsScriptableObject.LoadedScene)sceneBuildIndex;
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


            AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneBuildIndex);

            while (!asyncLoad.isDone)
            {
                yield return null;
            }

            if (_gameSettings.GetScene != GameSettingsScriptableObject.LoadedScene.MainMenu)
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

