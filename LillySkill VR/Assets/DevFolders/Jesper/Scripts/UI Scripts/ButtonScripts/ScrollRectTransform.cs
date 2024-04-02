using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace Jesper.Collection
{
    public class ScrollRectTransform : MonoBehaviour
    {
        [SerializeField]
        private RectTransform scrollRectObjectTransform;
        [SerializeField] private GameObject arrowUp, arrowDown;
        [SerializeField]
        private Vector3 currentTransform;
        [Tooltip("Variable that control the scrolling sensitivity.")]
        [SerializeField]
        private float scrollspeed = 0.55f;
        

        private void Start()
        {
            currentTransform = new Vector3(0.4f, 0.0f, 0.0f);
        }

        private void Update()
        {
            scrollRectObjectTransform.anchoredPosition = currentTransform;

            if (currentTransform.y <= 0.1f)
            {
                arrowUp.SetActive(false);
            }
            else if(currentTransform.y >= 3.5f)
            {
                arrowDown.SetActive(false);
            }
            else if(currentTransform.y >= 0.4f && currentTransform.y <= 3.25f)
            {
                arrowUp.SetActive(true);
                arrowDown.SetActive(true);
            }
            else
            {
                return;
            }
        }

        public void ScrollUp()
        {
            // Ensures scrolling stays within the defined bounds (0.0f to 4f).
            currentTransform.y = Mathf.Clamp(currentTransform.y - scrollspeed, 0.0f, Mathf.Infinity);
        }

        public void ScrollDown()
        {
            // Ensures scrolling stays within the defined bounds (0.0f to 4f).
            currentTransform.y = Mathf.Clamp(currentTransform.y + scrollspeed, -Mathf.Infinity, 3.85f);
        }
    }
}

