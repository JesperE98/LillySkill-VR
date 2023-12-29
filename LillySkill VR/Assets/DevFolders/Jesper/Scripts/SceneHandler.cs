using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace JespersCode
{
    public class SceneHandler : MonoBehaviour
    {
        private SceneHandler sceneHandler;

        private void Awake()
        {
            if (sceneHandler == null)
            {
                sceneHandler = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }

        public void SceneSwitch ()
        {
            SceneManager.LoadScene(0);
        }
    }
}

