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

        protected GameManager gameManager;
        protected GameObject UIPrefabCopy;

        protected bool uiPrefabIsActive = false;
        protected int index = 0;


        private void Awake()
        {
            gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();


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
            gameManager.EasyMode = true;
            gameManager.InterviewAreActive = true;
            gameManager.LoadedScene = 1;
            if (gameManager.LoadedScene == 1)
            {
                if (gameManager.EasyMode == true)
                {
                    gameManager.PlayerLife = 5;
                }
            }
            else if (gameManager.LoadedScene == 0)
            {
                CreateUIPrefab();
                
            }
        }

        private void Update()
        {
            // If the conditions are rightfully met, call the function named CreateUIPrefab.
            if (gameManager.LoadedScene == 1)
            {
                if (gameManager.PlayerLife > 0)
                {
                    if (gameManager.InterviewAreActive == true && uiPrefabIsActive == false)
                    {
                        CreateUIPrefab();
                    }
                }
                else if (gameManager.PlayerLife <= 0 && gameManager.InterviewAreActive == true)
                {
                    gameManager.InterviewAreActive = !gameManager.InterviewAreActive;
                    Debug.Log("THIS INTERVIEW IS OVER!!!!!");
                    UIPrefabCopy = Instantiate(UIPrefabs[1]);
                }
            }


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
                    Debug.Log("Loaded Scene: " + gameManager.LoadedScene);
                    UIPrefabCopy = Instantiate(UIPrefabs[0]);
                    break;

                case 1:
                    switch (index)
                    {
                        case 0:
                            // checks if UIPrefab copy "obj" are null. 
                            if (UIPrefabCopy == null)
                            {

                                // Checks if bool are false.
                                if (uiPrefabIsActive == false)
                                {
                                    // If all previous if statements meets the right condition, create a copy of the UI Prefab.
                                    Debug.Log("Hi UI! " + index);
                                    UIPrefabCopy = Instantiate(UIPrefabs[0]);

                                }
                                // After UI copy was created then reverse bool statement to halter the instantiation.
                                uiPrefabIsActive = !uiPrefabIsActive;

                            }
                            break;

                        case 1:
                            // checks if UIPrefab copy "obj" are null. 
                            if (UIPrefabCopy == null)
                            {

                                // Checks if bool are false.
                                if (uiPrefabIsActive == false)
                                {
                                    // If all previous if statements are true. Then create a copy of the UI Prefab.
                                    Debug.Log("Hi UI! " + index);
                                    UIPrefabCopy = Instantiate(UIPrefabs[0]);

                                }
                                // After UI copy was created then reverse bool statement to halter the instantiation.
                                uiPrefabIsActive = !uiPrefabIsActive;
                            }
                            break;

                        case 2:
                            // checks if UIPrefab copy "obj" are null. 
                            if (UIPrefabCopy == null)
                            {

                                // Checks if bool are false.
                                if (uiPrefabIsActive == false)
                                {
                                    // If all previous if statements are true. Then create a copy of the UI Prefab.
                                    Debug.Log("Hi UI! " + index);
                                    UIPrefabCopy = Instantiate(UIPrefabs[0]);
                                }
                                // After UI copy was created then reverse bool statement to halter the instantiation.
                                uiPrefabIsActive = !uiPrefabIsActive;
                            }
                            break;

                        case 3:
                            // checks if UIPrefab copy "obj" are null. 
                            if (UIPrefabCopy == null)
                            {

                                // Checks if bool are false.
                                if (uiPrefabIsActive == false)
                                {
                                    // If all previous if statements are true. Then create a copy of the UI Prefab.
                                    Debug.Log("Hi UI! " + index);
                                    UIPrefabCopy = Instantiate(UIPrefabs[0]);
                                }
                                // After UI copy was created then reverse bool statement to halter the instantiation.
                                uiPrefabIsActive = !uiPrefabIsActive;
                            }
                            break;

                        case 4:
                            // checks if UIPrefab copy "obj" are null. 
                            if (UIPrefabCopy == null)
                            {

                                // Checks if bool are false.
                                if (uiPrefabIsActive == false)
                                {
                                    // If all previous if statements are true. Then create a copy of the UI Prefab.
                                    Debug.Log("Hi UI! " + index);
                                    UIPrefabCopy = Instantiate(UIPrefabs[0]);
                                }
                                // After UI copy was created then reverse bool statement to halter the instantiation.
                                uiPrefabIsActive = !uiPrefabIsActive;
                            }
                            break;

                        case 5:
                            // checks if UIPrefab copy "obj" are null. 
                            if (UIPrefabCopy == null)
                            {

                                // Checks if bool are false.
                                if (uiPrefabIsActive == false)
                                {
                                    // If all previous if statements are true. Then create a copy of the UI Prefab.
                                    Debug.Log("Hi UI! " + index);
                                    UIPrefabCopy = Instantiate(UIPrefabs[0]);
                                }
                                // After UI copy was created then reverse bool statement to halter the instantiation.
                                uiPrefabIsActive = !uiPrefabIsActive;
                            }
                            break;

                        case 6:
                            // checks if UIPrefab copy "obj" are null. 
                            if (UIPrefabCopy == null)
                            {

                                // Checks if bool are false.
                                if (uiPrefabIsActive == false)
                                {
                                    // If all previous if statements are true. Then create a copy of the UI Prefab.
                                    Debug.Log("Hi UI! " + index);
                                    UIPrefabCopy = Instantiate(UIPrefabs[0]);
                                }
                                // After UI copy was created then reverse bool statement to halter the instantiation.
                                uiPrefabIsActive = !uiPrefabIsActive;
                            }
                            break;

                        default:
                            gameManager.InterviewAreActive = !gameManager.InterviewAreActive;

                            UIPrefabCopy = Instantiate(UIPrefabs[1]);
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
            switch (gameManager.EasyMode)
            {
                case true:
                    Debug.Log("EasyMode Initiated.");
                    if (gameManager.UsedBadAnswer == true)
                    {
                        gameManager.UsedBadAnswer = !gameManager.UsedBadAnswer;
                        gameManager.PlayerLife -= 1;
                        gameManager.PlayerScore += 0;
                        Debug.Log("Used Bad Answer");
                        StartCoroutine(DeleteUICopyRoutine());
                    }
                    else if (gameManager.UsedAverageAnswer == true)
                    {
                        gameManager.UsedAverageAnswer = !gameManager.UsedAverageAnswer;
                        gameManager.PlayerLife += 0;
                        gameManager.PlayerScore += 1;
                        Debug.Log("Used Average Answer");
                        StartCoroutine(DeleteUICopyRoutine());
                    }
                    else if (gameManager.UsedGoodAnswer == true)
                    {
                        gameManager.UsedGoodAnswer = !gameManager.UsedGoodAnswer;
                        gameManager.PlayerLife += 1;
                        gameManager.PlayerScore += 2;
                        Debug.Log("Used Good Answer");
                        StartCoroutine(DeleteUICopyRoutine());
                    }
                    break;
            }

            switch (gameManager.MediumMode)
            {
                case true:
                    Debug.Log("MediumMode initiated.");
                    if (gameManager.UsedWorstAnswer == true)
                    {
                        gameManager.UsedWorstAnswer = !gameManager.UsedWorstAnswer;
                        gameManager.PlayerLife -= 1;
                        gameManager.PlayerScore += 0;
                        Debug.Log("Used Worst Answer");
                        StartCoroutine(DeleteUICopyRoutine());
                    }
                    else if (gameManager.UsedBadAnswer == true)
                    {
                        gameManager.UsedBadAnswer = !gameManager.UsedBadAnswer;
                        gameManager.PlayerLife -= 1;
                        gameManager.PlayerScore += 0;
                        Debug.Log("Used Bad Answer");
                        StartCoroutine(DeleteUICopyRoutine());
                    }
                    else if (gameManager.UsedAverageAnswer == true)
                    {
                        gameManager.UsedAverageAnswer = !gameManager.UsedAverageAnswer;
                        gameManager.PlayerLife += 0;
                        gameManager.PlayerScore += 1;
                        Debug.Log("Used Average Answer");
                        StartCoroutine(DeleteUICopyRoutine());
                    }
                    else if (gameManager.UsedGoodAnswer == true)
                    {
                        gameManager.UsedGoodAnswer = !gameManager.UsedGoodAnswer;
                        gameManager.PlayerLife += 1;
                        gameManager.PlayerScore += 2;
                        Debug.Log("Used Good Answer");
                        StartCoroutine(DeleteUICopyRoutine());
                    }
                    else if (gameManager.UsedBestAnswer == true)
                    {
                        gameManager.UsedBestAnswer = !gameManager.UsedBestAnswer;
                        gameManager.PlayerLife += 1;
                        gameManager.PlayerScore += 3;
                        Debug.Log("Used Best Answer");
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
            Debug.Log("Coroutine started");
            Destroy(UIPrefabCopy);
            Debug.Log(gameManager.PlayerLife);
            Debug.Log(gameManager.PlayerScore);
            yield return new WaitForSeconds(2);
            index++;
            uiPrefabIsActive = !uiPrefabIsActive;

            Debug.Log("Coroutine ended");

        }
    }
}

