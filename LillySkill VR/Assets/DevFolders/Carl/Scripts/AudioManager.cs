using JespersCode;
using JesperScriptableObject;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource sFXAudioSource;
    [SerializeField] private AudioSource voiceAudioSource;
    [SerializeField] private AudioSource ambienceAudioSource;

    [SerializeField] private DefaultAudioScriptableObject sFXScriptableObject;
    [SerializeField] private VoiceAudioScriptableObject voiceScriptableObject;
    [SerializeField] private DefaultAudioScriptableObject ambienceScriptableObject;
    [SerializeField] private GameSettingsScriptableObject m_GameSettings;

    private GameManager gameManager;
    private UIManager uiManager;
    private Animator animator;


    private void Start()
    {
<<<<<<< Updated upstream
        if(m_GameSettings.LoadedScene != "Main Menu")
        {
            gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
            animator = GameObject.FindGameObjectWithTag("NPC").GetComponent<Animator>();
            uiManager = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>();
        }
=======
        if(gameManager != null)
        {
            gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        }
        else
        {
            Debug.LogWarning("GameManager is NULL!");
        }
        uiManager = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>();
        animator = GameObject.FindGameObjectWithTag("NPC").GetComponent<Animator>();
>>>>>>> Stashed changes
    }

    private void Update()
    {
<<<<<<< Updated upstream
        if (m_GameSettings.LoadedScene != "Main Menu")
        {
            if(gameManager.LillyIntroDone == true)
            {
                Debug.Log("Calling Method PlayAudioClip()");
                StartCoroutine(PlayAudioClip());
                gameManager.LillyIntroDone = false;
=======
        if(gameManager != null)
        {
            if (gameManager.LillyIntro == true && gameManager.LillyOutro == false)
            {
                StartCoroutine(PlayAudioClip());
                gameManager.LillyIntro = false;
>>>>>>> Stashed changes
            }
        }
    }


    public void StartAudioCoroutine()
    {
        StartCoroutine(PlayAudioClip());
    }

    /// <summary>
    /// Playes a SFX sound with the chosen index from the SFX scriptable object.
    /// </summary>
    /// <param name="index"></param>
    public void PlaySFXAudio(int index)
    {
        sFXAudioSource.clip = sFXScriptableObject.sounds[index].clip;
        sFXAudioSource.volume = sFXScriptableObject.sounds[index].volume;
        sFXAudioSource.spatialBlend = sFXScriptableObject.sounds[index].spatialBlend;
        sFXAudioSource.loop = sFXScriptableObject.sounds[index].loop;

        sFXAudioSource.Play();
    }

    /// <summary>
    /// Playes an audio from a scriptable object data container stored in the Voice scriptable object list.
    /// </summary>
    /// <param name="index"></param>
    public void PlayVoiceAudio(int voiceListIndex, int questionAudioIndex)
    {
        DefaultAudioScriptableObject s = voiceScriptableObject.questions[voiceListIndex];

        if(s != null)
        {
            voiceAudioSource.clip = s.sounds[questionAudioIndex].clip;
            voiceAudioSource.volume = s.sounds[questionAudioIndex].volume;
            voiceAudioSource.spatialBlend = s.sounds[questionAudioIndex].spatialBlend;
            voiceAudioSource.loop = s.sounds[questionAudioIndex].loop;

            voiceAudioSource.Play();
        }
    }

    /// <summary>
    /// Playes a Ambience sound with the chosen index from the Ambience scriptable object.
    /// </summary>
    /// <param name="index"></param>
    public void PlayAmbienceAudio(int index)
    {
        ambienceAudioSource.clip = ambienceScriptableObject.sounds[index].clip;
        ambienceAudioSource.volume = ambienceScriptableObject.sounds[index].volume;
        ambienceAudioSource.spatialBlend = ambienceScriptableObject.sounds[index].spatialBlend;
        ambienceAudioSource.loop = ambienceScriptableObject.sounds[index].loop;

        ambienceAudioSource.Play();
    }

    private IEnumerator PlayAudioClip()
    {
        animator.SetBool("AskingQuestion", true);

        if(gameManager.InterviewAreActive == false)
        {
            gameManager.InterviewAreActive = true;
        }


        switch (gameManager.AnswerPageNumber)
        {
            case 1:
                PlayVoiceAudio(0, 0);
                yield return new WaitForSeconds(voiceAudioSource.clip.length);
                break;

            case 2:
                PlayVoiceAudio(0, 1);
                yield return new WaitForSeconds(voiceAudioSource.clip.length);
                break;

            case 3:
                PlayVoiceAudio(0, 2);
                yield return new WaitForSeconds(voiceAudioSource.clip.length);
                break;

            case 4:
                PlayVoiceAudio(0, 3);
                yield return new WaitForSeconds(voiceAudioSource.clip.length);
                break;

            case 5:
                PlayVoiceAudio(0, 4);
                yield return new WaitForSeconds(voiceAudioSource.clip.length);
                break;

            case 6:
                PlayVoiceAudio(0, 5);
                yield return new WaitForSeconds(voiceAudioSource.clip.length);
                break;

            case 7:
                PlayVoiceAudio(1, 0);
                yield return new WaitForSeconds(voiceAudioSource.clip.length);
                break;

            case 8:
                PlayVoiceAudio(0, 6);
                yield return new WaitForSeconds(voiceAudioSource.clip.length);
                break;

            case 9:
                PlayVoiceAudio(1, 1);
                yield return new WaitForSeconds(voiceAudioSource.clip.length);
                break;

            case 10:
                PlayVoiceAudio(1, 2);
                yield return new WaitForSeconds(voiceAudioSource.clip.length);
                break;
        }

        if (gameManager.InterviewAreActive == true)
        {
            animator.SetBool("AskingQuestion", false);
            uiManager.ActivateUIPrefab();
        }
    }
}
