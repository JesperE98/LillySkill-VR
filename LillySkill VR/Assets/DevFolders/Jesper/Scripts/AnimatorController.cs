using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JespersCode
{
    public class AnimatorController : MonoBehaviour
    {
        private Animator animator;
        private GameManager gameManager;

        [SerializeField] private int value = 2;
        [SerializeField] private float dampTime;

        private void Awake()
        {
            animator = GetComponent<Animator>();
            gameManager = FindObjectOfType<GameManager>();
        }

        private void Update()
        {
            if (gameManager.InterviewAreActive == true)
            {
                AnimatorControls();
            }
        }

        private void AnimatorControls()
        {
            value = gameManager.InterviewerInterest;
            switch (gameManager.InterviewerInterest)
            {
                case 1:
                    animator.SetFloat("Blend", 0f, dampTime, Time.deltaTime);
                    break;

                case 2:
                    animator.SetFloat("Blend", 1.0f, dampTime, Time.deltaTime);
                    break;

                case 3:
                    animator.SetFloat("Blend", 2.0f, dampTime, Time.deltaTime);
                    break;

                case 4:
                    animator.SetFloat("Blend", 3.0f, dampTime, Time.deltaTime);
                    break;
            }
        }
    }

}
