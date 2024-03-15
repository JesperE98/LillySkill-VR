using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Jesper.Collection
{
    public class ScrollRectTransform : MonoBehaviour
    {
        [SerializeField]
        private RectTransform scrollRectObjectTransform;
        [SerializeField] private GameObject arrowUp, arrowDown;
        [SerializeField]
        private Vector3 currentTransform;

        private void Start()
        {
        }

        private void Update()
        {
            currentTransform.y = scrollRectObjectTransform.localPosition.y;

            if (currentTransform.y <= 0.8f)
            {
                arrowUp.SetActive(false);
            }
            else if(currentTransform.y >= 4f)
            {
                arrowDown.SetActive(false);
            }
            else if(currentTransform.y >= 0.85f && currentTransform.y <= 3.9f)
            {
                arrowUp.SetActive(true);
                arrowDown.SetActive(true);
            }
        }
    }
}

