using LillyCode;
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
        private GameManager gameManager;

        [Header("UI Generic Lists")]
        [Tooltip("Generic List to add UI Prefabs.")]
        public List<GameObject> UIPrefabs = new List<GameObject>();

        [HideInInspector]
        ///<summary>
        ///Generic List that stores copies of the UI Prefabs.
        /// </summary>
        public List<GameObject> uiPrefabCopyList = new List<GameObject>();

        private GameObject prefabCopy;

        [Tooltip("Choose what GameObject in the hierarchy to store the UI copies")]
        [SerializeField]
        private GameObject UIPrefabCollector;


        [SerializeField]
        private bool uiPrefabIsActive = false;



        private void Awake()
        {
            gameManager = FindObjectOfType<GameManager>();
        }
        

        private void Start()
        {
            for (int i = 0; i < UIPrefabs.Count; i++)
            {
                prefabCopy = Instantiate(UIPrefabs[i], UIPrefabCollector.transform);
                prefabCopy.SetActive(false);
                uiPrefabCopyList.Add(prefabCopy);
            }

            uiPrefabCopyList[0].SetActive(true); // Activates LillyUI at the start.

            if (gameManager.LoadedScene == 0)
            {
                ActivateUIPrefab();
            }
        }

        private void Update()
        {


            //if (_gameManager.InterviewerInterest <= 0 && _gameManager.InterviewAreActive == true)
            //{
            //    _gameManager.InterviewAreActive = !_gameManager.InterviewAreActive;
            //    Instantiate(_uiPrefabCopyList[1]);
            //}


            // If statements to make sure the value stays between the values 1 to 5.
            if (gameManager.InterviewerInterest >= 5)
                gameManager.InterviewerInterest = 5;
            else if (gameManager.InterviewerInterest <= 1)
                gameManager.InterviewerInterest = 1;

            if (gameManager.InterviewerIntro == true)
            {
                StartCoroutine(gameManager.InterviewIntro());
                gameManager.InterviewerIntro = false;
            }

        }

        /// <summary>
        /// Creates the UI Prefab copy and renames it to obj
        /// </summary>
        public void ActivateUIPrefab()
        {
            // Switch statement that checks which active scene it is.
            switch(gameManager.LoadedScene)
            {
                case 0:
                    uiPrefabCopyList[0].SetActive(true);
                    break;

                case 1:
                    switch (gameManager.AnswerPageNumber)
                    {
                        case 1:
                            
                            // Checks if bool are false.
                            if (uiPrefabIsActive == false)
                            {
                                // If all previous if statements meets the right condition, create a copy of the UI Prefab.  
                                uiPrefabCopyList[1].SetActive(true);
                                uiPrefabCopyList[2].SetActive(true);
                                uiPrefabIsActive = true;
                            }
                            break;

                        case 2:
                            // Checks if bool are false.
                            if (uiPrefabIsActive == false)
                            {
                                // If all previous if statements meets the right condition, create a copy of the UI Prefab.  
                                uiPrefabCopyList[1].SetActive(true);
                                uiPrefabCopyList[2].SetActive(true);
                                uiPrefabIsActive = true;
                            }
                            break;

                        case 3:
                            // Checks if bool are false.
                            if (uiPrefabIsActive == false)
                            {
                                // If all previous if statements meets the right condition, create a copy of the UI Prefab.  
                                uiPrefabCopyList[1].SetActive(true);
                                uiPrefabCopyList[2].SetActive(true);
                                uiPrefabIsActive = true;
                            }
                            break;

                        case 4:
                            // Checks if bool are false.
                            if (uiPrefabIsActive == false)
                            {
                                // If all previous if statements meets the right condition, create a copy of the UI Prefab.  
                                uiPrefabCopyList[1].SetActive(true);
                                uiPrefabCopyList[2].SetActive(true);
                                uiPrefabIsActive = true;
                            }
                            break;

                        case 5:
                            // Checks if bool are false.
                            if (uiPrefabIsActive == false)
                            {
                                // If all previous if statements meets the right condition, create a copy of the UI Prefab.  
                                uiPrefabCopyList[1].SetActive(true);
                                uiPrefabCopyList[2].SetActive(true);
                                uiPrefabIsActive = true;
                            }
                            break;

                        case 6:
                            // Checks if bool are false.
                            if (uiPrefabIsActive == false)
                            {
                                // If all previous if statements meets the right condition, create a copy of the UI Prefab.  
                                uiPrefabCopyList[1].SetActive(true);
                                uiPrefabCopyList[2].SetActive(true);
                                uiPrefabIsActive = true;
                            }
                            break;

                        case 7:
                            // Checks if bool are false.
                            if (uiPrefabIsActive == false)
                            {
                                // If all previous if statements meets the right condition, create a copy of the UI Prefab.  
                                uiPrefabCopyList[1].SetActive(true);
                                uiPrefabCopyList[2].SetActive(true);
                                uiPrefabIsActive = true;
                            }
                            break;

                        case 8:
                            // Checks if bool are false.
                            if (uiPrefabIsActive == false)
                            {
                                // If all previous if statements meets the right condition, create a copy of the UI Prefab.  
                                uiPrefabCopyList[1].SetActive(true);
                                uiPrefabCopyList[2].SetActive(true);
                                uiPrefabIsActive = true;
                            }
                            break;

                        case 9:
                            // Checks if bool are false.
                            if (uiPrefabIsActive == false)
                            {
                                // If all previous if statements meets the right condition, create a copy of the UI Prefab.  
                                uiPrefabCopyList[1].SetActive(true);
                                uiPrefabCopyList[2].SetActive(true);
                                uiPrefabIsActive = true;
                            }
                            break;

                        case 10:
                            // Checks if bool are false.
                            if (uiPrefabIsActive == false)
                            {
                                // If all previous if statements meets the right condition, create a copy of the UI Prefab.  
                                uiPrefabCopyList[1].SetActive(true);
                                uiPrefabCopyList[2].SetActive(true);
                                uiPrefabIsActive = true;

                            }
                            break;

                        default:
                            if (uiPrefabIsActive == false)
                            {
                                uiPrefabCopyList[5].SetActive(true);
                                gameManager.LillyOutro = true;
                                uiPrefabIsActive = true;
                                gameManager.InterviewAreActive = false; // Ska plockas bort efter demo visningen
                            }
                            break;
                    }
                    break;
            }
        }

        public void StartUIDeactivation()
        {
            StartCoroutine(DeactivateUICopy(1));
        }

        /// <summary>
        /// Coroutine to update the properties PlayerLife and PlayerScore and to Destroy the UIPrefabCopy and increment the index variable.
        /// </summary>
        /// <returns></returns>
        public IEnumerator DeactivateUICopy(int listIndex)
        {
            // Check if the index is valid
            if (listIndex < 0 || listIndex >= uiPrefabCopyList.Count)
            {
                Debug.LogError("Index out of range!");
                yield break;
            }

            uiPrefabCopyList[listIndex].SetActive(false);
            uiPrefabCopyList[2].SetActive(false);

            gameManager.AnswerPageNumber++;

            uiPrefabIsActive = false;

            if (gameManager.AnswerPageNumber >= 10) { ActivateUIPrefab(); }
        }
    }
}

