using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace JespersCode
{
    [RequireComponent(typeof(BoxCollider))]
    /// <summary>
    /// Deriving class of class Button to act like a bridge between the CardboardReticlePointer script and the Buttons class
    /// so you can interact with UI Buttons with the Raycast CardboardReticlePointer
    /// </summary>
    public class UIController : Button
    {
        private AudioManager _audioManager;
        protected override void Awake()
        {
            _audioManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();
        }

        /// <summary>
        /// This method is called by the Main Camera when it starts gazing at this GameObject.
        /// </summary>
        public void OnPointerEnter()
        {
            _audioManager.PlaySFXAudio(1);
        }

        /// <summary>
        /// This method is called by the Main Camera when it stops gazing at this GameObject.
        /// </summary>
        //public void OnPointerExit()
        //{
        //    string message = "OnPointerExit";
        //    print(message);
        //}

        /// <summary>
        /// This method is called by the Main Camera when it is gazing at this GameObject and the screen
        /// is touched.
        /// </summary>
        public void OnPointerClick()
        {
            onClick.Invoke();
            _audioManager.PlaySFXAudio(0);
        }
    }
}

