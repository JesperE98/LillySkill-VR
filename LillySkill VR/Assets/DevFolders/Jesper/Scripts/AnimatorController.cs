using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JespersCode;

public class AnimatorController : MonoBehaviour
{
    private Animator _animator;
    private GameManager _gameManager;

    [SerializeField] private int value = 2;
    [SerializeField] private float dampTime;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    private void Update()
    {
       if(_gameManager.InterviewAreActive == true)
        {
            AnimatorControls();
        }
        //AnimatorControls();
    }

    private void AnimatorControls()
    {
        value = _gameManager.InterviewerInterest;
        switch(_gameManager.InterviewerInterest)
        {
            case 1:
                _animator.SetFloat("Blend", 0f, dampTime, Time.deltaTime);
                break;

            case 2:
                _animator.SetFloat("Blend", 1.0f, dampTime, Time.deltaTime);
                break;

            case 3:
                _animator.SetFloat("Blend", 2.0f, dampTime, Time.deltaTime);
                break;

            case 4:
                _animator.SetFloat("Blend", 3.0f, dampTime, Time.deltaTime);
                break;
        }
    }
}
