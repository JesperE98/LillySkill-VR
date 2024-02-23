using JespersCode;
using System;
using System.Collections;
using System.Linq;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Tooltip("A list containing all the soundsources from the AudioManager. " +
        "\n\nCall function: FindObjectOfType<AudioManager>().Play('NAME'); " +
        "\nWhere NAME is the name of the sound.")]
    public Sound[] sounds;
    private GameManager gameManager;
    private UIManager uiManager;
    private Animator animator;

    private void Awake()
    {
        gameManager = FindAnyObjectByType<GameManager>();
        uiManager = FindAnyObjectByType<UIManager>();
        animator = GameObject.FindGameObjectWithTag("NPC").GetComponent<Animator>();

        // Adds an audiosource to the AudioManager. Also makes that, for each audiosource,
        // the data in the list updates the audiosource component values.  
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.spatialBlend = s.spatialBlend;
            s.source.loop = s.loop;
            s.source.outputAudioMixerGroup = s.mixerGroup;
        }
    }

    private void Start()
    {
        Play("Ambience");
    }

    private void Update()
    {
        foreach (Sound s in sounds)
        {
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.spatialBlend = s.spatialBlend;
            s.source.loop = s.loop;
            s.source.outputAudioMixerGroup = s.mixerGroup;
        }

        if (gameManager.LillyIntro == true && gameManager.LillyOutro == false)
        {
            StartCoroutine(PlayAudioClip());
            gameManager.LillyIntro = false;
        }
    }

    public void StartAudioCoroutine()
    {
        StartCoroutine(PlayAudioClip());
    }

    /// <summary>
    /// Plays an audioclip with the given name from the AudioManager 
    /// </summary>
    /// <param name="name"></param>
    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            // Is written in the console if the name of the audioclip wasn't found
            Debug.LogWarning("Sound: '" + name + "' was not found!");
            return;
        }
        s.source.Play();
    }

    private IEnumerator PlayAudioClip()
    {
        animator.SetBool("AskingQuestion", true);

        if(gameManager.InterviewAreActive == false)
        {
            gameManager.InterviewAreActive = true;

            Play("Hej och välkommen");

            yield return new WaitForSeconds(sounds.ElementAt(7).clip.length + 1.0f);

            Play("AE F 2");

            yield return new WaitForSeconds(sounds.ElementAt(8).clip.length);
        }


        switch (gameManager.AnswerPageNumber)
        {
            case 2:
                Play("AE F 11");
                yield return new WaitForSeconds(sounds.ElementAt(9).clip.length);
                break;

            case 3:
                Play("AE F 8");
                yield return new WaitForSeconds(sounds.ElementAt(10).clip.length);
                break;

            case 4:
                Play("AE F 7");
                yield return new WaitForSeconds(sounds.ElementAt(11).clip.length);
                break;

            case 5:
                Play("AE F 3");
                yield return new WaitForSeconds(sounds.ElementAt(12).clip.length);
                break;

            case 6:
                Play("AE F 6");
                yield return new WaitForSeconds(sounds.ElementAt(13).clip.length);
                break;

            case 7:
                Play("IAE F 9");
                yield return new WaitForSeconds(sounds.ElementAt(14).clip.length);
                break;

            case 8:
                Play("AE F 10");
                yield return new WaitForSeconds(sounds.ElementAt(15).clip.length);
                break;

            case 9:
                Play("IAE F 5");
                yield return new WaitForSeconds(sounds.ElementAt(16).clip.length);
                break;

            case 10:
                Play("IAE F 8");
                yield return new WaitForSeconds(sounds.ElementAt(17).clip.length);
                break;

                /////////////////////////////////////////////////////////////////////// Commented section below will be uncommented after Betra test are done ////////////////////////////////////////////////
                //case 11:
                //    Play("AE F 4");
                //    yield return new WaitForSeconds(sounds.ElementAt(18).clip.length);
                //    break;

                //case 12:
                //    Play("AE F 9");
                //    yield return new WaitForSeconds(sounds.ElementAt(19).clip.length);
                //    break;

                //case 13:
                //    Play("AE F 5");
                //    yield return new WaitForSeconds(sounds.ElementAt(20).clip.length);
                //    break;

                //case 14:
                //    Play("AE F 1");
                //    yield return new WaitForSeconds(sounds.ElementAt(21).clip.length);
                //    break;

                //case 15:
                //    Play("IAE F 2");
                //    yield return new WaitForSeconds(sounds.ElementAt(22).clip.length);
                //    break;

                //case 16:
                //    Play("IAE F 1");
                //    yield return new WaitForSeconds(sounds.ElementAt(23).clip.length);
                //    break;

                //case 17:
                //    Play("IAE F 4");
                //    yield return new WaitForSeconds(sounds.ElementAt(24).clip.length);
                //    break;

                //case 18:
                //    Play("IAE F 6");
                //    yield return new WaitForSeconds(sounds.ElementAt(25).clip.length);
                //    break;

                //case 19:
                //    Play("IAE F 3");
                //    yield return new WaitForSeconds(sounds.ElementAt(26).clip.length);
                //    break;

                //case 20:
                //    Play("IAE F 7");
                //    yield return new WaitForSeconds(sounds.ElementAt(27).clip.length);
                //    break;
        }


        if (gameManager.InterviewAreActive == true)
        {
            animator.SetBool("AskingQuestion", false);
            uiManager.ActivateUIPrefab();
        }
    }
}
