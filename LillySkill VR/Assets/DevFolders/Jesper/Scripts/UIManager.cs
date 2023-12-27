using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] UIPrefabs;
    private GameObject UIPrefabCopy;
    [SerializeField]
    private bool uiPrefabIsActive = false;
    [SerializeField]
    private bool interviewAreActive = true;
    [SerializeField]
    private byte index = 0; 

    private void Update()
    {
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
        Debug.Log("Im active!");
        StartCoroutine(DeleteUICopyRoutine());
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
