using JespersCode;
using JesperScriptableObject;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;

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


    private void Awake()
    {
        if(m_GameSettings.LoadedScene != 0)
        {
            gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
            animator = GameObject.FindGameObjectWithTag("NPC").GetComponent<Animator>();
        }
        uiManager = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>();
    }

    private void Update()
    {
        if(m_GameSettings.LoadedScene == 1)
        {
            if (gameManager.LillyIntro == true && gameManager.LillyOutro == false)
            {
                StartCoroutine(PlayAudioClip());
                gameManager.LillyIntro = false;
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

            //PlayVoiceAudio(0, 0);

            //yield return new WaitForSeconds(voiceAudioSource.clip.length);
        }


        switch (gameManager.AnswerPageNumber)
        {
            case 0:
                print("Hi");
                PlayVoiceAudio(0, 0);
                yield return new WaitForSeconds(voiceAudioSource.clip.length);
                break;

            case 1:
                print("Hi");
                PlayVoiceAudio(0, 1);
                yield return new WaitForSeconds(voiceAudioSource.clip.length);
                break;

            case 2:
                print("Hi");
                PlayVoiceAudio(0, 2);
                yield return new WaitForSeconds(voiceAudioSource.clip.length);
                break;

            case 3:
                print("Hi");
                PlayVoiceAudio(0, 3);
                yield return new WaitForSeconds(voiceAudioSource.clip.length);
                break;

            case 4:
                print("Hi");
                PlayVoiceAudio(0, 4);
                yield return new WaitForSeconds(voiceAudioSource.clip.length);
                break;

            case 5:
                print("Hi");
                PlayVoiceAudio(0, 5);
                yield return new WaitForSeconds(voiceAudioSource.clip.length);
                break;

            case 6:
                print("Hi");
                PlayVoiceAudio(0, 6);
                yield return new WaitForSeconds(voiceAudioSource.clip.length);
                break;

            case 7:
                print("Hi");
                PlayVoiceAudio(0, 7);
                yield return new WaitForSeconds(voiceAudioSource.clip.length);
                break;

            case 8:
                print("Hi");
                PlayVoiceAudio(0, 8);
                yield return new WaitForSeconds(voiceAudioSource.clip.length);
                break;

            case 9:
                print("Hi");
                PlayVoiceAudio(0, 9);
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
