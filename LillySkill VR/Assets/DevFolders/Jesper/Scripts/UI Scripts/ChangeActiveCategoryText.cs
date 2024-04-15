using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ChangeActiveCategoryText : MonoBehaviour
{
    private TMP_Text tmpText;

    /// <summary>
    /// List that contains all the categories on the category UI page.
    /// </summary>
    [Tooltip("Add all the categoires on the category UI Page.")]
    [SerializeField]
    private List<GameObject> categoryPageCategories;


    void Start()
    {
        tmpText = GetComponent<TMP_Text>();
    }

    void Update()
    {
        // Goes through the List to check if there are any activated categories by loojing for the child
        // GameObject called "Checkmark". And if there are, update the tmpText variable.
        int activeCheckmarks = 0;
        for (int i = 0; i < categoryPageCategories.Count; i++)
        {
            Transform childTransform = categoryPageCategories[i].transform.GetChild(1);

            if (childTransform != null && childTransform.gameObject.name == "Checkmark" && childTransform.gameObject.activeInHierarchy)
            {
                activeCheckmarks++;
            }
        }
        tmpText.text = $"Antal valda kategorier: {activeCheckmarks}/{categoryPageCategories.Count}";
    }
}
