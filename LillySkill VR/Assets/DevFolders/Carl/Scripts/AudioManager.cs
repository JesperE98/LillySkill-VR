using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;
using Jesper.Collection;
using Jesper.GameSettings.Data;
using Jesper.InterviewAnswersAndQuestions.Data;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource sFXAudioSource;
    [SerializeField] private AudioSource voiceAudioSource;
    [SerializeField] private AudioSource ambienceAudioSource;

    [SerializeField] private DefaultAudioScriptableObject sFXScriptableObject;
    [SerializeField] private VoiceAudioDataBankScriptableObject voiceScriptableObject;
    [SerializeField] private DefaultAudioScriptableObject ambienceScriptableObject;
    [SerializeField] private GameSettingsScriptableObject m_GameSettings;
    [SerializeField]
    private int randomAudioListIndex;
    [SerializeField]
    private int randomAudioSubListIndex;
    [SerializeField]
    private float soundDuration;

    private GameManager gameManager;
    private UIManager uiManager;
    private Animator animator;
    [SerializeField] private bool playingAudioClip = false;

    public List<DefaultAudioScriptableObject> activeInterviewAudioCategories = new List<DefaultAudioScriptableObject>();

    public bool PlayingAudioClip
    {
        get
        {
            return playingAudioClip;
        }
        set
        {
            playingAudioClip = value;
        }
    }

    private void Awake()
    {
        switch (m_GameSettings.GetScene != GameSettingsScriptableObject.LoadedScene.MainMenu)
        {
            case true:
                gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
                animator = GameObject.FindGameObjectWithTag("NPC").GetComponent<Animator>();
                uiManager = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>();
                break;

            case false:
                
                break;
        }
    }

    private void Start()
    {
        switch (m_GameSettings.GetScene)
        {
            case GameSettingsScriptableObject.LoadedScene.MainMenu:
                PlayAmbienceAudio(0);
                break;

            case GameSettingsScriptableObject.LoadedScene.Office:
                PlayAmbienceAudio(0);
                ResetInterviewAudioData();
                break;

            case GameSettingsScriptableObject.LoadedScene.Tutorial:
                PlayAmbienceAudio(0);
                ResetInterviewAudioData();
                break;

            default:

                break;
        }
    }

    private void Update()
    {
        switch (m_GameSettings.GetScene)
        {
            case GameSettingsScriptableObject.LoadedScene.MainMenu:

                break;

            case GameSettingsScriptableObject.LoadedScene.Office:
                if(gameManager != null)
                {
                    randomAudioListIndex = gameManager.RandomListIndex;
                    randomAudioSubListIndex = gameManager.RandomSubListIndex;
                    soundDuration = activeInterviewAudioCategories[randomAudioListIndex].sounds[randomAudioSubListIndex].clip.length;
                }
                else
                {
                    return;
                }

                if (playingAudioClip == false && gameManager.FadeInComplete == true)
                {
                    Debug.Log("Playing AudioClip!");
                    StartCoroutine(PlayAudioClip());
                    playingAudioClip = true;
                }
                else
                {
                    return;
                }

                break;

            case GameSettingsScriptableObject.LoadedScene.Tutorial:
                randomAudioListIndex = gameManager.RandomListIndex;
                randomAudioSubListIndex = gameManager.RandomSubListIndex;
                soundDuration = activeInterviewAudioCategories[randomAudioListIndex].sounds[randomAudioSubListIndex].clip.length;

                if (gameManager.InterviewAreActive)
                {
                    if (gameManager.LillyIntroDone == true)
                    {
                        Debug.Log("Calling Method PlayAudioClip()");
                        StartAudioCoroutine();
                        gameManager.LillyIntroDone = false;
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    return;
                }

                break;
        }
    }

    private void ResetInterviewAudioData()
    {
        var voiceDataList = voiceScriptableObject.questions;

        activeInterviewAudioCategories.Clear();

        // Goes through all data in InterviewAnswersAndQuestions list categoriesDatas and creates deep copies of the categorys
        // that are active and adds them to the GameManagers list _activeInterviewCategories.
        foreach (var data in voiceDataList)
        {
            if (data.audioCategoryIsActive == true)
            {
                data.Clone();

                activeInterviewAudioCategories.Add(data);
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
        DefaultAudioScriptableObject s = activeInterviewAudioCategories[voiceListIndex];

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

    public IEnumerator PlayAudioClip()
    {
        if (gameManager.InterviewAreActive)
        {
            animator.SetBool("AskingQuestion", true);
            PlayVoiceAudio(randomAudioListIndex, randomAudioSubListIndex);
            yield return new WaitForSeconds(soundDuration + 0.2f);
            animator.SetBool("AskingQuestion", false);
            uiManager.ActivateUIPrefab();
        }
        else
        {
            uiManager.ActivateUIPrefab();
        }
    }
}
