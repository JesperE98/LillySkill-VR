using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace JespersCode
{
    public class UIManager : MonoBehaviour
    {
        protected static UIManager _uiManager;

        [Header("UI")]
        [Tooltip("Array for UI Prefabs.")]
        public GameObject[] UIPrefabs;

        protected GameManager _gameManager;
        protected GameObject _uiPrefabCopy;
        protected Animator _animtor;
        protected bool _uiPrefabIsActive = false;
        protected int _index = 0;


        private void Awake()
        {
            _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
            _animtor = GameObject.FindGameObjectWithTag("NPC").GetComponent<Animator>();


            if (_uiManager == null) // Moves the UIManager GameObject to the DontDestroyOnLoad page when loading in the play mode.
            {
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }

        private void Start()
        {
            _gameManager.EasyMode = true;
            _gameManager.InterviewAreActive = true;
            _gameManager.LoadedScene = 1;
            if (_gameManager.LoadedScene == 1)
            {
                if (_gameManager.EasyMode == true)
                {
                    _gameManager.InterviewerInterest = 2;
                }
            }
            else if (_gameManager.LoadedScene == 0)
            {
                CreateUIPrefab();
                
            }

            if(_gameManager.InterviewerInterest >= 5)
            {
                _gameManager.InterviewerInterest = 5;
            }
            else if(_gameManager.InterviewerInterest <= 1)
            {
                _gameManager.InterviewerInterest = 1;
            }
        }

        private void Update()
        {
            // If the conditions are rightfully met, call the function named CreateUIPrefab.
            if (_gameManager.LoadedScene == 1)
            {
                if (_gameManager.InterviewerInterest > 0)
                {
                    if (_gameManager.InterviewAreActive == true && _uiPrefabIsActive == false)
                    {
                        CreateUIPrefab();
                    }
                }
                else if (_gameManager.InterviewerInterest <= 0 && _gameManager.InterviewAreActive == true)
                {
                    _gameManager.InterviewAreActive = !_gameManager.InterviewAreActive;
                    _uiPrefabCopy = Instantiate(UIPrefabs[1]);
                }
            }


        }

        /// <summary>
        /// Creates the UI Prefab copy and renames it to obj
        /// </summary>
        private void CreateUIPrefab()
        {
            // Switch statement that checks which active scene it is.
            switch(_gameManager.LoadedScene)
            {
                case 0:
                    _uiPrefabCopy = Instantiate(UIPrefabs[0]);
                    break;

                case 1:
                    switch (_index)
                    {
                        case 0:
                            // checks if UIPrefab copy "obj" are null. 
                            if (_uiPrefabCopy == null)
                            {

                                // Checks if bool are false.
                                if (_uiPrefabIsActive == false)
                                {
                                    // If all previous if statements meets the right condition, create a copy of the UI Prefab.
                                    _uiPrefabCopy = Instantiate(UIPrefabs[0]);

                                }
                                // After UI copy was created then reverse bool statement to halter the instantiation.
                                _uiPrefabIsActive = !_uiPrefabIsActive;

                            }
                            break;

                        case 1:
                            // checks if UIPrefab copy "obj" are null. 
                            if (_uiPrefabCopy == null)
                            {

                                // Checks if bool are false.
                                if (_uiPrefabIsActive == false)
                                {
                                    // If all previous if statements are true. Then create a copy of the UI Prefab.
                                    _uiPrefabCopy = Instantiate(UIPrefabs[0]);

                                }
                                // After UI copy was created then reverse bool statement to halter the instantiation.
                                _uiPrefabIsActive = !_uiPrefabIsActive;
                            }
                            break;

                        case 2:
                            // checks if UIPrefab copy "obj" are null. 
                            if (_uiPrefabCopy == null)
                            {

                                // Checks if bool are false.
                                if (_uiPrefabIsActive == false)
                                {
                                    // If all previous if statements are true. Then create a copy of the UI Prefab.
                                    _uiPrefabCopy = Instantiate(UIPrefabs[0]);
                                }
                                // After UI copy was created then reverse bool statement to halter the instantiation.
                                _uiPrefabIsActive = !_uiPrefabIsActive;
                            }
                            break;

                        case 3:
                            // checks if UIPrefab copy "obj" are null. 
                            if (_uiPrefabCopy == null)
                            {

                                // Checks if bool are false.
                                if (_uiPrefabIsActive == false)
                                {
                                    // If all previous if statements are true. Then create a copy of the UI Prefab.
                                    _uiPrefabCopy = Instantiate(UIPrefabs[0]);
                                }
                                // After UI copy was created then reverse bool statement to halter the instantiation.
                                _uiPrefabIsActive = !_uiPrefabIsActive;
                            }
                            break;

                        case 4:
                            // checks if UIPrefab copy "obj" are null. 
                            if (_uiPrefabCopy == null)
                            {

                                // Checks if bool are false.
                                if (_uiPrefabIsActive == false)
                                {
                                    // If all previous if statements are true. Then create a copy of the UI Prefab.
                                    _uiPrefabCopy = Instantiate(UIPrefabs[0]);
                                }
                                // After UI copy was created then reverse bool statement to halter the instantiation.
                                _uiPrefabIsActive = !_uiPrefabIsActive;
                            }
                            break;

                        case 5:
                            // checks if UIPrefab copy "obj" are null. 
                            if (_uiPrefabCopy == null)
                            {

                                // Checks if bool are false.
                                if (_uiPrefabIsActive == false)
                                {
                                    // If all previous if statements are true. Then create a copy of the UI Prefab.
                                    _uiPrefabCopy = Instantiate(UIPrefabs[0]);
                                }
                                // After UI copy was created then reverse bool statement to halter the instantiation.
                                _uiPrefabIsActive = !_uiPrefabIsActive;
                            }
                            break;

                        case 6:
                            // checks if UIPrefab copy "obj" are null. 
                            if (_uiPrefabCopy == null)
                            {

                                // Checks if bool are false.
                                if (_uiPrefabIsActive == false)
                                {
                                    // If all previous if statements are true. Then create a copy of the UI Prefab.
                                    _uiPrefabCopy = Instantiate(UIPrefabs[0]);
                                }
                                // After UI copy was created then reverse bool statement to halter the instantiation.
                                _uiPrefabIsActive = !_uiPrefabIsActive;
                            }
                            break;

                        default:
                            _gameManager.InterviewAreActive = !_gameManager.InterviewAreActive;

                            _uiPrefabCopy = Instantiate(UIPrefabs[1]);
                            break;
                    }
                    break;

                default:

                    break;
            }

            
        }

        /// <summary>
        /// Waiting for one of the UI Buttons in the prefab to be pressed. If it is, then start Coroutine called DeleteUICopyRoutine.
        /// </summary>
        public void UIButtonPressed()
        {
            switch (_gameManager.EasyMode)
            {
                case true:
                    Debug.Log("EasyMode Initiated.");
                    if (_gameManager.UsedBadAnswer == true)
                    {
                        _gameManager.UsedBadAnswer = !_gameManager.UsedBadAnswer;
                        _gameManager.InterviewerInterest -= 1;
                        _gameManager.PlayerScore += 0;
                        StartCoroutine(DeleteUICopyRoutine());
                    }
                    else if (_gameManager.UsedAverageAnswer == true)
                    {
                        _gameManager.UsedAverageAnswer = !_gameManager.UsedAverageAnswer;
                        _gameManager.InterviewerInterest += 0;
                        _gameManager.PlayerScore += 1;
                        StartCoroutine(DeleteUICopyRoutine());
                    }
                    else if (_gameManager.UsedGoodAnswer == true)
                    {
                        _gameManager.UsedGoodAnswer = !_gameManager.UsedGoodAnswer;
                        _gameManager.InterviewerInterest += 1;
                        _gameManager.PlayerScore += 2;
                        StartCoroutine(DeleteUICopyRoutine());
                    }
                    break;
            }

            switch (_gameManager.MediumMode)
            {
                case true:
                    Debug.Log("MediumMode initiated.");
                    if (_gameManager.UsedWorstAnswer == true)
                    {
                        _gameManager.UsedWorstAnswer = !_gameManager.UsedWorstAnswer;
                        _gameManager.InterviewerInterest -= 1;
                        _gameManager.PlayerScore += 0;
                        StartCoroutine(DeleteUICopyRoutine());
                    }
                    else if (_gameManager.UsedBadAnswer == true)
                    {
                        _gameManager.UsedBadAnswer = !_gameManager.UsedBadAnswer;
                        _gameManager.InterviewerInterest -= 1;
                        _gameManager.PlayerScore += 0;
                        StartCoroutine(DeleteUICopyRoutine());
                    }
                    else if (_gameManager.UsedAverageAnswer == true)
                    {
                        _gameManager.UsedAverageAnswer = !_gameManager.UsedAverageAnswer;
                        _gameManager.InterviewerInterest += 0;
                        _gameManager.PlayerScore += 1;
                        StartCoroutine(DeleteUICopyRoutine());
                    }
                    else if (_gameManager.UsedGoodAnswer == true)
                    {
                        _gameManager.UsedGoodAnswer = !_gameManager.UsedGoodAnswer;
                        _gameManager.InterviewerInterest += 1;
                        _gameManager.PlayerScore += 2;
                        StartCoroutine(DeleteUICopyRoutine());
                    }
                    else if (_gameManager.UsedBestAnswer == true)
                    {
                        _gameManager.UsedBestAnswer = !_gameManager.UsedBestAnswer;
                        _gameManager.InterviewerInterest += 1;
                        _gameManager.PlayerScore += 3;
                        StartCoroutine(DeleteUICopyRoutine());
                    }
                    break;
            }
        }

        /// <summary>
        /// Coroutine to update the properties PlayerLife and PlayerScore and to Destroy the UIPrefabCopy and increment the index variable.
        /// </summary>
        /// <returns></returns>
        public virtual IEnumerator DeleteUICopyRoutine()
        {
            Destroy(_uiPrefabCopy);
            Debug.Log(_gameManager.InterviewerInterest);
            Debug.Log(_gameManager.PlayerScore);
            
            yield return new WaitForSeconds(15);
            _animtor.SetBool("AskingQuestion", false);
            _index++;
            _uiPrefabIsActive = !_uiPrefabIsActive;
        }
    }
}

