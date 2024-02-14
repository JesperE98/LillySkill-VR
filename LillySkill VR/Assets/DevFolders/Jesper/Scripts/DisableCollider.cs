using JespersCode;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JespersCode
{
    public class DisableCollider : MonoBehaviour
    {
        private GameManager gameManager;
        private BoxCollider boxCollider;

        private void Awake()
        {
            gameManager = FindObjectOfType<GameManager>();
            boxCollider = GetComponent<BoxCollider>();
        }

        void Update()
        {
            if (gameManager.InterviewAreActive == false) { boxCollider.enabled = false; }
            else if (gameManager.InterviewAreActive == true) { boxCollider.enabled = true; }
        }
    }
}

