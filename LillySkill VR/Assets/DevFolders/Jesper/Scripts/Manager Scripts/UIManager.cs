using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace JespersCode
{
    public class UIManager : MonoBehaviour
    {
        private static UIManager uiManager;
        private GameManager gameManager;
        private Animator animator;

        [Header("UI Generic Lists")]
        [Tooltip("Generic List to add UI Prefabs.")]
        public List<GameObject> UIPrefabs = new List<GameObject>();

        [HideInInspector]
        ///<summary>
        ///Generic List that stores copies of the UI Prefabs.
        /// </summary>
        public List<GameObject> uiPrefabCopyList = new List<GameObject>();

        private GameObject obj;

        [Tooltip("Choose what GameObject in the hierarchy to store the UI copies")]
        [SerializeField]
        private GameObject UIPrefabCollector;


        [SerializeField]
        private bool uiPrefabIsActive = false;
        private int index = 0;


        private void Awake()
        {
            gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
            animator = GameObject.FindGameObjectWithTag("NPC").GetComponent<Animator>();


            if (uiManager == null) // Moves the UIManager GameObject to the DontDestroyOnLoad page when loading in the play mode.
            {
                uiManager = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Object.Destroy(gameObject);
            }

            for (int i = 0; i < UIPrefabs.Count; i++)
            {
                obj = Instantiate(UIPrefabs[i], UIPrefabCollector.transform);
                obj.SetActive(false);
                uiPrefabCopyList.Add(obj);
            }
        }
        

        private void Start()
        {
            // Manually set some parameters for Demo version of the project.
            // Will be deleted in the future.
            gameManager.EasyMode = true;
            gameManager.InterviewAreActive = true;
            gameManager.LoadedScene = 1;


            if (gameManager.LoadedScene == 1)
            {
                if (gameManager.EasyMode == true)
                {
                    gameManager.InterviewerInterest = 3;
                }
            }
            else if (gameManager.LoadedScene == 0)
            {
                CreateUIPrefab();
            }
        }

        private void Update()
        {
            // If the conditions are met, call the function named CreateUIPrefab.
            if (gameManager.LoadedScene == 1)
            {
                if (gameManager.InterviewerInterest > 0)
                {
                    if (gameManager.InterviewAreActive == true && uiPrefabIsActive == false)
                    {
                        CreateUIPrefab();
                    }
                }
                //else if (_gameManager.InterviewerInterest <= 0 && _gameManager.InterviewAreActive == true)
                //{
                //    _gameManager.InterviewAreActive = !_gameManager.InterviewAreActive;
                //    Instantiate(_uiPrefabCopyList[1]);
                //}
            }

            // If statements to make sure the value stays between the values 1 to 5.
            if (gameManager.InterviewerInterest >= 5)
                gameManager.InterviewerInterest = 5;
            else if (gameManager.InterviewerInterest <= 1)
                gameManager.InterviewerInterest = 1;

        }

        /// <summary>
        /// Creates the UI Prefab copy and renames it to obj
        /// </summary>
        private void CreateUIPrefab()
        {
            // Switch statement that checks which active scene it is.
            switch(gameManager.LoadedScene)
            {
                case 0:
                    uiPrefabCopyList[0].SetActive(true);
                    break;

                case 1:
                    switch (index)
                    {
                        case 0:
                            gameManager.AnswerPageNumber = 1;
                            // Checks if bool are false.
                            if (uiPrefabIsActive == false)
                            {
                                // If all previous if statements meets the right condition, create a copy of the UI Prefab.  
                                uiPrefabCopyList[0].SetActive(true);
                                uiPrefabIsActive = true;
                            }
                            break;

                        case 1:
                            // Checks if bool are false.
                            if (uiPrefabIsActive == false)
                            {
                                // If all previous if statements meets the right condition, create a copy of the UI Prefab.  
                                uiPrefabCopyList[0].SetActive(true);
                                uiPrefabIsActive = true;
                            }
                            break;

                        case 2:
                            // Checks if bool are false.
                            if (uiPrefabIsActive == false)
                            {
                                // If all previous if statements meets the right condition, create a copy of the UI Prefab.  
                                uiPrefabCopyList[0].SetActive(true);
                                uiPrefabIsActive = true;
                            }
                            break;

                        case 3:
                            // Checks if bool are false.
                            if (uiPrefabIsActive == false)
                            {
                                // If all previous if statements meets the right condition, create a copy of the UI Prefab.  
                                uiPrefabCopyList[0].SetActive(true);
                                uiPrefabIsActive = true;
                            }
                            break;

                        case 4:
                            // Checks if bool are false.
                            if (uiPrefabIsActive == false)
                            {
                                // If all previous if statements meets the right condition, create a copy of the UI Prefab.  
                                uiPrefabCopyList[0].SetActive(true);
                                uiPrefabIsActive = true;
                            }
                            break;

                        case 5:
                            // Checks if bool are false.
                            if (uiPrefabIsActive == false)
                            {
                                // If all previous if statements meets the right condition, create a copy of the UI Prefab.  
                                uiPrefabCopyList[0].SetActive(true);
                                uiPrefabIsActive = true;
                            }
                            break;

                        case 6:
                            // Checks if bool are false.
                            if (uiPrefabIsActive == false)
                            {
                                // If all previous if statements meets the right condition, create a copy of the UI Prefab.  
                                uiPrefabCopyList[0].SetActive(true);
                                uiPrefabIsActive = true;
                            }
                            break;

                        default:
                            print("Default Case");
                            if (uiPrefabIsActive == false)
                            {
                                uiPrefabCopyList[1].SetActive(true);
                                uiPrefabIsActive = true;
                                gameManager.InterviewAreActive = !gameManager.InterviewAreActive;
                            }
                            break;
                    }
                    break;
            }
        }

        /// <summary>
        /// Waiting for one of the UI Buttons in the prefab to be pressed. If it is, then start Coroutine called DeleteUICopyRoutine.
        /// </summary>
        public void UIButtonPressed()
        {
            switch (gameManager.EasyMode)
            {
                case true:
                    if (gameManager.UsedBadAnswer == true)
                    {
                        gameManager.UsedBadAnswer = !gameManager.UsedBadAnswer; // Sets bool value back to false.
                        gameManager.InterviewerInterest -= 1;
                        gameManager.PlayerScore += 0;
                        StartCoroutine(DeleteUICopyRoutine(0));
                    }
                    else if (gameManager.UsedAverageAnswer == true)
                    {
                        gameManager.UsedAverageAnswer = !gameManager.UsedAverageAnswer; // Sets bool value back to false.
                        gameManager.InterviewerInterest += 0;
                        gameManager.PlayerScore += 1;
                        StartCoroutine(DeleteUICopyRoutine(0));
                    }
                    else if (gameManager.UsedGoodAnswer == true)
                    {
                        gameManager.UsedGoodAnswer = !gameManager.UsedGoodAnswer; // Sets bool value back to false.
                        gameManager.InterviewerInterest += 1;
                        gameManager.PlayerScore += 2;
                        StartCoroutine(DeleteUICopyRoutine(0));
                    }
                    break;
            }

            switch (gameManager.MediumMode)
            {
                case true:
                    if (gameManager.UsedWorstAnswer == true)
                    {
                        gameManager.UsedWorstAnswer = !gameManager.UsedWorstAnswer;
                        gameManager.InterviewerInterest -= 1;
                        gameManager.PlayerScore += 0;
                        StartCoroutine(DeleteUICopyRoutine(0));
                    }
                    else if (gameManager.UsedBadAnswer == true)
                    {
                        gameManager.UsedBadAnswer = !gameManager.UsedBadAnswer;
                        gameManager.InterviewerInterest -= 1;
                        gameManager.PlayerScore += 0;
                        StartCoroutine(DeleteUICopyRoutine(0));
                    }
                    else if (gameManager.UsedAverageAnswer == true)
                    {
                        gameManager.UsedAverageAnswer = !gameManager.UsedAverageAnswer;
                        gameManager.InterviewerInterest += 0;
                        gameManager.PlayerScore += 1;
                        StartCoroutine(DeleteUICopyRoutine(0));
                    }
                    else if (gameManager.UsedGoodAnswer == true)
                    {
                        gameManager.UsedGoodAnswer = !gameManager.UsedGoodAnswer;
                        gameManager.InterviewerInterest += 1;
                        gameManager.PlayerScore += 2;
                        StartCoroutine(DeleteUICopyRoutine(0));
                    }
                    else if (gameManager.UsedBestAnswer == true)
                    {
                        gameManager.UsedBestAnswer = !gameManager.UsedBestAnswer;
                        gameManager.InterviewerInterest += 1;
                        gameManager.PlayerScore += 3;
                        StartCoroutine(DeleteUICopyRoutine(0));
                    }
                    break;
            }
        }

        /// <summary>
        /// Coroutine to update the properties PlayerLife and PlayerScore and to Destroy the UIPrefabCopy and increment the index variable.
        /// </summary>
        /// <returns></returns>
        private IEnumerator DeleteUICopyRoutine(int listIndex)
        {
            // Check if the index is valid
            if (listIndex < 0 || listIndex >= uiPrefabCopyList.Count)
            {
                Debug.LogError("Index out of range!");
                yield break;
            }

            uiPrefabCopyList[listIndex].SetActive(false);

            index++;
            gameManager.AnswerPageNumber++;
            yield return new WaitForSeconds(3f);
            animator.SetBool("AskingQuestion", false);
            uiPrefabIsActive = false;
        }

        private void DeactivateObject(int index)
        {
            print("Deactivating objects.");
            GameObject obj = uiPrefabCopyList[index];
            obj.SetActive(false);
        }
    }
}

