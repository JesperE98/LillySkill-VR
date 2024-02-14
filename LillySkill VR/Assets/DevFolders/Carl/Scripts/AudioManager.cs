using JespersCode;
using System;
using System.Collections;
using System.Linq;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using static Unity.VisualScripting.Member;

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
        foreach (Sound s in sounds) // Finns det något sätt att ersätta det här t. ex. Ha EN Audiosource och byta ljudet dynamiskt under körning?
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.spatialBlend = s.spatialBlend;
            s.source.loop = s.loop;
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
        }

        if (gameManager.LillyIntro == true && gameManager.LillyOutro == false)
        {
            print("Hej hej lilly");
            StartCoroutine(PlayAudioClip());
            gameManager.LillyIntro = false;
        }
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

    public void StartAudioCoroutine()
    {
        StartCoroutine(PlayAudioClip());
    }

    private IEnumerator PlayAudioClip()
    {
        animator.SetBool("AskingQuestion", true);

        if(gameManager.LillyOutro == false)
        {
            print("Lilly Outro false");
            if (gameManager.InterviewAreActive == false) // Determines if the introduction audio should be played.
            {
                Play("Hej och välkommen");
                yield return new WaitForSeconds(sounds.ElementAt(7).clip.length); // "Pauses" the code until the previous audio clip are done.
                gameManager.InterviewerIntro = true; // Sets bool value to true to indicate that the program can start the interview.
            }

            if (gameManager.InterviewerIntro == true)
            {
                Play("AE F 2");
                yield return new WaitForSeconds(sounds.ElementAt(8).clip.length);
            }
        }


        // Goes through each individual cases based on what Answerpage the user are on and play that specific audioclip from a list.
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

                ////////////////////////////////////////////////////////////// Commented section bellow will be uncommented after Demo test are done.////////////////////////////////////////////////////////////////////
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
        if(gameManager.InterviewAreActive == true) 
        {
            animator.SetBool("AskingQuestion", false);
            uiManager.ActivateUIPrefab(); 
        }
    }
}
