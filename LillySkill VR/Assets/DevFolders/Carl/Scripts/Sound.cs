using UnityEngine;

[System.Serializable]
public class Sound // A class that contains all the data for the audioclips used in the AudioManager
{
    public string name;

    public AudioClip clip;

    [Range(0f, 1f)]
    public float volume;

    [Header("2D => 3D")]
    [Range(0f, 1f)]
    public float spatialBlend;

    public bool loop;

    [HideInInspector]
    public AudioSource source;
}
