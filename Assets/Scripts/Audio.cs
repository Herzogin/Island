using UnityEngine.Audio;
using UnityEngine;

//To make the custom class appear in the Unity editor, it has to be Serializable
[System.Serializable]
public class Audio
{
    public AudioClip clip;
    public string name;

    [Range(0f, 1f)]
    public float volume;

    [HideInInspector]
    public AudioSource source;
}
