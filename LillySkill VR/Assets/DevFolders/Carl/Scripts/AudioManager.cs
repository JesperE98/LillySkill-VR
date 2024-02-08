using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Tooltip("A list containing all the soundsources from the AudioManager. " +
        "\n\nCall function: FindObjectOfType<AudioManager>().Play('NAME'); " +
        "\nWhere NAME is the name of the sound.")]
    public Sound[] sounds;

    private void Awake()
    {
        // Adds an audiosource to the AudioManager. Also makes that, for each audiosource,
        // the data in the list updates the audiosource component values.  
        foreach (Sound s in sounds)
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
}
