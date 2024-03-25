using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using LillyCode;
using Jesper.GameSettings.Data;


namespace Jesper.Collection
{
    public class UIManager : MonoBehaviour
    {
        private GameManager _gameManager;
        private GameObject _prefabCopy;

        [SerializeField]
        private GameSettingsScriptableObject _gameSettings;
        [Header("UI Generic Lists")]
        [Tooltip("Generic List to add UI Prefabs.")]
        public List<GameObject> UIPrefabs = new List<GameObject>();


        ///<summary>
        ///Generic List that stores copies of the UI Prefabs.
        /// </summary>
        [SerializeField]
        public List<GameObject> uiPrefabCopyList = new List<GameObject>();


        [Tooltip("Choose what GameObject in the hierarchy to store the UI copies")]
        [SerializeField]
        private GameObject _uIPrefabCollector;
        [SerializeField]
        private bool _uiPrefabIsActive = false;

        private void Awake()
        {
            if(_gameSettings.LoadedScene != "Main Menu")
            {
                _gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
            }
        }
        
        private void Start()
        {
            for (int i = 0; i < UIPrefabs.Count; i++)
            {
                _prefabCopy = Instantiate(UIPrefabs[i], _uIPrefabCollector.transform);
                _prefabCopy.SetActive(false);
                uiPrefabCopyList.Add(_prefabCopy);
            }


            if (_gameSettings.LoadedScene == "Main Menu")
            {
                ActivateUIPrefab();
            }
            else if( _gameSettings.LoadedScene == "Tutorial")
            {
                uiPrefabCopyList[0].SetActive(true); // Activates LillyUI at the start.
            }
            else if(_gameSettings.LoadedScene == "Office")
            {
                ActivateUIPrefab();
            }
        }

        /// <summary>
        /// Creates the UI Prefab copy and renames it to obj
        /// </summary>
        public void ActivateUIPrefab()
        {
            // Switch statement that checks which active scene it is.
            switch(_gameSettings.LoadedScene)
            {
                case "Main Menu":
                    uiPrefabCopyList[0].SetActive(true);
                    break;

                case "Tutorial":
                    switch (_gameManager.AnswerPageNumber)
                    {
                        case 0:
                            
                            // Checks if bool are false.
                            if (_uiPrefabIsActive == false)
                            {
                                // If all previous if statements meets the right condition, create a copy of the UI Prefab.  
                                uiPrefabCopyList[1].SetActive(true);
                                uiPrefabCopyList[2].SetActive(true);
                                _uiPrefabIsActive = true;
                            }
                            break;

                        case 1:
                            // Checks if bool are false.
                            if (_uiPrefabIsActive == false)
                            {
                                // If all previous if statements meets the right condition, create a copy of the UI Prefab.  
                                uiPrefabCopyList[1].SetActive(true);
                                uiPrefabCopyList[2].SetActive(true);
                                _uiPrefabIsActive = true;
                            }
                            break;

                        case 2:
                            // Checks if bool are false.
                            if (_uiPrefabIsActive == false)
                            {
                                // If all previous if statements meets the right condition, create a copy of the UI Prefab.  
                                uiPrefabCopyList[1].SetActive(true);
                                uiPrefabCopyList[2].SetActive(true);
                                _uiPrefabIsActive = true;
                            }
                            break;

                        case 3:
                            // Checks if bool are false.
                            if (_uiPrefabIsActive == false)
                            {
                                // If all previous if statements meets the right condition, create a copy of the UI Prefab.  
                                uiPrefabCopyList[1].SetActive(true);
                                uiPrefabCopyList[2].SetActive(true);
                                _uiPrefabIsActive = true;
                            }
                            break;

                        case 4:
                            // Checks if bool are false.
                            if (_uiPrefabIsActive == false)
                            {
                                // If all previous if statements meets the right condition, create a copy of the UI Prefab.  
                                uiPrefabCopyList[1].SetActive(true);
                                uiPrefabCopyList[2].SetActive(true);
                                _uiPrefabIsActive = true;
                            }
                            break;

                        case 5:
                            // Checks if bool are false.
                            if (_uiPrefabIsActive == false)
                            {
                                // If all previous if statements meets the right condition, create a copy of the UI Prefab.  
                                uiPrefabCopyList[1].SetActive(true);
                                uiPrefabCopyList[2].SetActive(true);
                                _uiPrefabIsActive = true;
                            }
                            break;

                        case 6:
                            // Checks if bool are false.
                            if (_uiPrefabIsActive == false)
                            {
                                // If all previous if statements meets the right condition, create a copy of the UI Prefab.  
                                uiPrefabCopyList[1].SetActive(true);
                                uiPrefabCopyList[2].SetActive(true);
                                _uiPrefabIsActive = true;
                            }
                            break;

                        case 7:
                            // Checks if bool are false.
                            if (_uiPrefabIsActive == false)
                            {
                                // If all previous if statements meets the right condition, create a copy of the UI Prefab.  
                                uiPrefabCopyList[1].SetActive(true);
                                uiPrefabCopyList[2].SetActive(true);
                                _uiPrefabIsActive = true;
                            }
                            break;

                        case 8:
                            // Checks if bool are false.
                            if (_uiPrefabIsActive == false)
                            {
                                // If all previous if statements meets the right condition, create a copy of the UI Prefab.  
                                uiPrefabCopyList[1].SetActive(true);
                                uiPrefabCopyList[2].SetActive(true);
                                _uiPrefabIsActive = true;
                            }
                            break;

                        case 9:
                            // Checks if bool are false.
                            if (_uiPrefabIsActive == false)
                            {
                                // If all previous if statements meets the right condition, create a copy of the UI Prefab.  
                                uiPrefabCopyList[1].SetActive(true);
                                uiPrefabCopyList[2].SetActive(true);
                                _uiPrefabIsActive = true;

                            }
                            break;

                        default:
                            if (_uiPrefabIsActive == false)
                            {
                                uiPrefabCopyList[5].SetActive(true);
                                _gameManager.LillyOutroDone = true;
                                _uiPrefabIsActive = true;
                                _gameManager.InterviewAreActive = false; // Ska plockas bort efter demo visningen
                            }
                            break;
                    }
                    break;

                case "Office":
                    if(_gameManager.InterviewAreActive == true && _gameManager.WaitForAnswer == false)
                    {
                        uiPrefabCopyList[0].SetActive(true);
                        //_gameManager.WaitForAnswer = true;
                    }
                    break;
            }
        }

        public void StartUIDeactivation()
        {
            StartCoroutine(DeactivateUICopy(0));
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
            //uiPrefabCopyList[2].SetActive(false);

            //_gameManager.AnswerPageNumber++;

            //_uiPrefabIsActive = false;


            if (_gameManager.InterviewAreActive == true) { ActivateUIPrefab(); }
        }
    }
}

