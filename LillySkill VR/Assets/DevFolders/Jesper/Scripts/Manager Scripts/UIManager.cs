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
        private GameManager gameManager;
        private GameObject prefabCopy;
        private InterviewAnswersAndQuestions.Data.CategoriesData.CategoryName categoryName;

        [SerializeField]
        private GameSettingsScriptableObject gameSettings;
        [Tooltip("Choose what GameObject in the hierarchy to store the UI copies")]
        [SerializeField]
        private GameObject uIPrefabCollector;

        [Header("UI Generic Lists")]
        [Tooltip("Generic List to add UI Prefabs.")]
        public List<GameObject> UIPrefabs = new List<GameObject>();
        ///<summary>
        ///Generic List that stores copies of the UI Prefabs.
        /// </summary>
        protected internal List<GameObject> uiPrefabCopyList = new List<GameObject>();



        private void Awake()
        {
            if(gameSettings.GetScene != GameSettingsScriptableObject.LoadedScene.MainMenu)
            {
                gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
            }
            else
            {
                return;
            }
        }
        
        private void Start()
        {
            for (int i = 0; i < UIPrefabs.Count; i++)
            {
                prefabCopy = Instantiate(UIPrefabs[i], uIPrefabCollector.transform);
                prefabCopy.SetActive(false);
                uiPrefabCopyList.Add(prefabCopy);
            }


            if (gameSettings.GetScene == GameSettingsScriptableObject.LoadedScene.MainMenu)
            {
                ActivateUIPrefab();
            }
            else if(gameSettings.GetScene == GameSettingsScriptableObject.LoadedScene.Tutorial)
            {
                if(uiPrefabCopyList.Count < 0)
                {
                    Debug.LogWarning("Prefab copy list are empty!");
                }
                else
                {
                    return;
                }

                if (gameManager.TutorialDone)
                {
                    uiPrefabCopyList[3].SetActive(true); // Activates LillyUI at the start.
                }
                else
                {
                    return;
                }
            }
        }

        private void Update()
        {
            categoryName = gameManager._activeInterviewCategories[gameManager.RandomListIndex].categoryName;

            if (!gameManager.InterviewAreActive && gameManager.FeedbackPageAreActive)
            {
                ActivateUIPrefab();
            }
        }

        /// <summary>
        /// Deactivates the UIPrefabCopy.
        /// </summary>
        /// <returns></returns>
        public void StartUIDeactivation(int listIndex)
        {
            // Check if the index is valid
            if (listIndex < 0 || listIndex >= uiPrefabCopyList.Count)
            {
                Debug.LogError("Index out of range!");
                return;
            }

            uiPrefabCopyList[listIndex].SetActive(false);
        }

        /// <summary>
        /// Creates the UI Prefab copy and renames it to obj
        /// </summary>
        public void ActivateUIPrefab()
        {
            // Switch statement that checks which active scene it is.
            switch(gameSettings.GetScene)
            {
                case GameSettingsScriptableObject.LoadedScene.MainMenu:
                    uiPrefabCopyList[0].SetActive(true);
                    break;

                case GameSettingsScriptableObject.LoadedScene.Office:
                    switch (gameManager.InterviewAreActive)
                    {
                        case true:
                            if (categoryName != InterviewAnswersAndQuestions.Data.CategoriesData.CategoryName.Default)
                            {
                                uiPrefabCopyList[0].SetActive(true);
                            }
                            else
                            {
                                uiPrefabCopyList[1].SetActive(true);
                            }

                            break;

                        case false:
                            uiPrefabCopyList[0].SetActive(false);
                            uiPrefabCopyList[1].SetActive(false);
                            uiPrefabCopyList[2].SetActive(true);
                            gameManager.FeedbackPageAreActive = !gameManager.FeedbackPageAreActive;
                            break;
                    }

                    if (gameManager.InterviewAreActive == true && gameManager.WaitForAnswer == false)
                    {

                        //_gameManager.WaitForAnswer = true;
                    }
                    else if (gameManager.InterviewAreActive == false)
                    {

                    }
                    break;

                case GameSettingsScriptableObject.LoadedScene.Tutorial:
                    switch (gameManager.TutorialDone)
                    {
                        case false:
                            uiPrefabCopyList[0].SetActive(true);
                            break;

                        case true:
                            uiPrefabCopyList[1].SetActive(true);
                            break;
                    }
                    break;

            }
        }


    }
}

