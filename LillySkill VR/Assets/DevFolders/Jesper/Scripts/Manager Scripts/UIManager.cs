using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Unity.Burst.Intrinsics.X86.Avx;


namespace JespersCode
{
    public class UIManager : MonoBehaviour
    {
        private static UIManager _uiManager;
        private static UIManager SharedInstance;

        [Header("UI")]
        [Tooltip("Array for UI Prefabs.")]
        public GameObject[] UIPrefabs;

        [SerializeField]
        private GameObject UIPrefabCollector;

        private GameManager _gameManager;
        private GameObject _uiPrefabCopy;
        private Animator _animator;


        [SerializeField]
        private List<GameObject> pooledUIObjects = new List<GameObject>();
        [SerializeField]
        private GameObject objectToPool;
        [SerializeField]
        private int amountToPool;
         
        private bool uiPrefabIsActive = false;
        private int index = 0;


        private void Awake()
        {
            _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
            _animator = GameObject.FindGameObjectWithTag("NPC").GetComponent<Animator>();


            if (_uiManager == null) // Moves the UIManager GameObject to the DontDestroyOnLoad page when loading in the play mode.
            {
                DontDestroyOnLoad(gameObject);
            }
            else if(_uiManager != null)
            {
                Destroy(gameObject);
            }

            for (int i = 0; i < amountToPool; i++)
            {
                _uiPrefabCopy = Instantiate(objectToPool, UIPrefabCollector.transform);
                _uiPrefabCopy.SetActive(false);
                pooledUIObjects.Add(_uiPrefabCopy);
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
                    _gameManager.InterviewerInterest = 3;
                }
            }
            else if (_gameManager.LoadedScene == 0)
            {
                CreateUIPrefab();
            }
        }

        private void Update()
        {
            // If the conditions are rightfully met, call the function named CreateUIPrefab.
            if (_gameManager.LoadedScene == 1)
            {
                if (_gameManager.InterviewerInterest > 0)
                {
                    if (_gameManager.InterviewAreActive == true && uiPrefabIsActive == false)
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

            if (_gameManager.InterviewerInterest >= 5)
                _gameManager.InterviewerInterest = 5;
            else if (_gameManager.InterviewerInterest <= 1)
                _gameManager.InterviewerInterest = 1;

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
                    switch (index)
                    {
                        case 0:
                            // Checks if bool are false.
                            if (uiPrefabIsActive == false)
                            {
                                // If all previous if statements meets the right condition, create a copy of the UI Prefab.
                                pooledUIObjects[index].SetActive(true);

                            }
                            // After UI copy was created then reverse bool statement to halter the instantiation.
                            uiPrefabIsActive = !uiPrefabIsActive;

                            break;

                        //case 1:
                        //    // Checks if bool are false.
                        //    if (uiPrefabIsActive == false)
                        //    {
                        //        // If all previous if statements meets the right condition, create a copy of the UI Prefab.
                        //        pooledObjects[index].SetActive(true);

                        //    }
                        //    // After UI copy was created then reverse bool statement to halter the instantiation.
                        //    uiPrefabIsActive = !uiPrefabIsActive;

                        //    break;

                        //case 2:
                        //    // Checks if bool are false.
                        //    if (uiPrefabIsActive == false)
                        //    {
                        //        // If all previous if statements meets the right condition, create a copy of the UI Prefab.
                        //        pooledObjects[index].SetActive(true);

                        //    }
                        //    // After UI copy was created then reverse bool statement to halter the instantiation.
                        //    uiPrefabIsActive = !uiPrefabIsActive;

                        //    break;

                        //case 3:
                        //    // Checks if bool are false.
                        //    if (uiPrefabIsActive == false)
                        //    {
                        //        // If all previous if statements meets the right condition, create a copy of the UI Prefab.
                        //        pooledObjects[index].SetActive(true);

                        //    }
                        //    // After UI copy was created then reverse bool statement to halter the instantiation.
                        //    uiPrefabIsActive = !uiPrefabIsActive;
                        //    break;

                        //case 4:
                        //    // Checks if bool are false.
                        //    if (uiPrefabIsActive == false)
                        //    {
                        //        // If all previous if statements meets the right condition, create a copy of the UI Prefab.
                        //        pooledObjects[index].SetActive(true);

                        //    }
                        //    // After UI copy was created then reverse bool statement to halter the instantiation.
                        //    uiPrefabIsActive = !uiPrefabIsActive;

                        //    break;

                        //case 5:
                        //    // Checks if bool are false.
                        //    if (uiPrefabIsActive == false)
                        //    {
                        //        // If all previous if statements meets the right condition, create a copy of the UI Prefab.
                        //        pooledObjects[index].SetActive(true);

                        //    }
                        //    // After UI copy was created then reverse bool statement to halter the instantiation.
                        //    uiPrefabIsActive = !uiPrefabIsActive;

                        //    break;

                        //case 6:
                        //    // Checks if bool are false.
                        //    if (uiPrefabIsActive == false)
                        //    {
                        //        // If all previous if statements meets the right condition, create a copy of the UI Prefab.
                        //        pooledObjects[index].SetActive(true);

                        //    }
                        //    // After UI copy was created then reverse bool statement to halter the instantiation.
                        //    uiPrefabIsActive = !uiPrefabIsActive;

                        //    break;

                        default:
                            _gameManager.InterviewAreActive = !_gameManager.InterviewAreActive;

                            _uiPrefabCopy = Instantiate(UIPrefabs[0], UIPrefabCollector.transform);
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
        private IEnumerator DeleteUICopyRoutine()
        {
            pooledUIObjects[index].SetActive(false);
            Debug.Log(_gameManager.InterviewerInterest);
            Debug.Log(_gameManager.PlayerScore);
            yield return new WaitForSeconds(15);
            _animator.SetBool("AskingQuestion", false);
            index++;
            uiPrefabIsActive = !uiPrefabIsActive;
        }
    }
}

