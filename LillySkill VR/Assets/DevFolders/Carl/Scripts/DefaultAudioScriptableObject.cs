using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AudioData", menuName = "ScriptableObjects/DefaultAudioScriptableObject", order = 1)]
public class DefaultAudioScriptableObject : ScriptableObject
{
    /// <summary>
    /// On/Off switch for the category voice audio.
    /// </summary>
    [Tooltip("On/Off switch for the category voice audio.")]
    public bool audioCategoryIsActive = false;

    public List<Sound> sounds;

    public DefaultAudioScriptableObject Clone()
    {
        DefaultAudioScriptableObject copy = CreateInstance<DefaultAudioScriptableObject>();
        copy.audioCategoryIsActive = audioCategoryIsActive;
        copy.sounds = sounds;
        return copy;
    }


    [System.Serializable]
    public class Sound
    {
        public string name;

        public AudioClip clip;

        [Range(0f, 1f)]
        public float volume;

        [Header("2D => 3D")]
        [Range(0f, 1f)]
        public float spatialBlend;

        public bool loop;
    }
}
