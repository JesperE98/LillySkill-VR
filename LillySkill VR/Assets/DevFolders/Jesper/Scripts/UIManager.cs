using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private static UIManager _uiManager;

    [Header("UI")]
    [Space()]
    [Tooltip("Array for UI AnswerCanvas Prefabs here.")]
    [SerializeField] private GameObject[] UIPrefabs;

    private GameManager gameManager;
    private GameObject UIPrefabCopy;
    private bool uiPrefabIsActive = false;
    private bool interviewAreActive = true;
    private byte index = 0;


    private void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        if (_uiManager == null)
        {
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        // If the conditions are rightfully met, call the function named CreateUIPrefab.
        if (interviewAreActive == true && uiPrefabIsActive == false)
        {
            CreateUIPrefab();
        }
    }

    /// <summary>
    /// Creates the UI Prefab copy and renames it to obj
    /// </summary>
    private void CreateUIPrefab()
    {
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
                interviewAreActive = !interviewAreActive;
                break;
        }
    }

    /// <summary>
    /// Waiting for one of the UI Buttons in the prefab to be pressed. If it is, then start Coroutine called DeleteUICopyRoutine.
    /// </summary>
    public void UIButtonPressed()
    {
        if (gameManager.UsedWorstAnswer == true)
        {
            gameManager.UsedWorstAnswer = !gameManager.UsedWorstAnswer;
            Debug.Log("Used Worst Answer");
            StartCoroutine(DeleteUICopyRoutine());
        }
        else if (gameManager.UsedBadAnswer == true)
        {
            gameManager.UsedBadAnswer = !gameManager.UsedBadAnswer;
            Debug.Log("Used Bad Answer");
            StartCoroutine(DeleteUICopyRoutine());
        }
        else if (gameManager.UsedAverageAnswer == true)
        {
            gameManager.UsedAverageAnswer = !gameManager.UsedAverageAnswer;
            Debug.Log("Used Average Answer");
            StartCoroutine(DeleteUICopyRoutine());
        }
        else if (gameManager.UsedGoodAnswer == true)
        {
            gameManager.UsedGoodAnswer = !gameManager.UsedGoodAnswer;
            Debug.Log("Used Good Answer");
            StartCoroutine(DeleteUICopyRoutine());
        }
        else if (gameManager.UsedBestAnswer == true)
        {
            gameManager.UsedBestAnswer = !gameManager.UsedBestAnswer;
            Debug.Log("Used Best Answer");
            StartCoroutine(DeleteUICopyRoutine());
        }
    }


    private IEnumerator DeleteUICopyRoutine()
    {
        Debug.Log("Coroutine started");
        Destroy(UIPrefabCopy);
        yield return new WaitForSeconds(5);
        index++;
        uiPrefabIsActive = !uiPrefabIsActive;

        Debug.Log("Coroutine ended");
    }
}
