using JespersCode;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraRaycast : MonoBehaviour
{
    [Tooltip("Timer that activates a GiveHintsRoutine IEnumerator after the given number.")]
    [SerializeField] private float timer;

    private UIManager uiManager;
    private IEnumerator giveHints;

    private void Awake()
    {
        uiManager = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>();
    }

    private void FixedUpdate()
    {
        ChecksRaycastCollision();
    }

    /// <summary>
    /// Checks if Raycast hit a object with layer number 7 on it and start a coroutine.
    /// </summary>
    private void ChecksRaycastCollision()
    {
        RaycastHit hitInfo;
        int layerMask = 1 << 6; // This will make sure the Raycast only triggers when hitting layer 7 (RaycastLayer).

        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 10, Color.green);

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hitInfo, 10f, layerMask))
        {
            if (giveHints != null)
            {
                StopCoroutine(giveHints);
            }

            giveHints = GiveHintsRoutine();
            StartCoroutine(giveHints);
        }
    }

    /// <summary>
    /// IEnumerator that checks if the Raycast hit a object to return null. If Raycast stops hitting object then wait for X seconds to Instantiate a GiveHint UI Prefab. 
    /// </summary>
    /// <returns></returns>
    private IEnumerator GiveHintsRoutine()
    {
        RaycastHit hitInfo;
        int layerMask = 1 << 6;

        while (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hitInfo, 10f, layerMask))
        {
            yield return null;
        }

        yield return new WaitForSeconds(timer);
        GameObject prefabCopy = Instantiate(uiManager.UIPrefabs[3]);

        Destroy(prefabCopy, 3);
    }
}
