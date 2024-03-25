using JesperScriptableObject;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JespersCode
{
    public class ChangeQualityLevel : MonoBehaviour
    {
        [SerializeField]
        private GameSettingsScriptableObject m_GameSettings;

        /// <summary>
        /// Changes the quality level to URP Performant
        /// </summary>
        public void SetPerformantQuality()
        {
            m_GameSettings.PerformantQuality();
        }

        /// <summary>
        /// Changes the quality level to URP Balanced
        /// </summary>
        public void SetBalancedQuality()
        {
            m_GameSettings.BalancedQuality();
        }

        /// <summary>
        /// Changes the quality level to URP High Fidelity
        /// </summary>
        public void SetHighFidelityQuality()
        {
            m_GameSettings.HighFidelityQuality();
        }
    }
}

