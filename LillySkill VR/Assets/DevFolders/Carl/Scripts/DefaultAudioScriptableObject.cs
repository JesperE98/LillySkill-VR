using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AudioData", menuName = "ScriptableObjects/DefaultAudioScriptableObject", order = 1)]
public class DefaultAudioScriptableObject : ScriptableObject
{
    public List<Sound> sounds;

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
