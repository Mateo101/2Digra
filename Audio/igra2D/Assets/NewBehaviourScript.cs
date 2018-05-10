using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;


[System.Serializable]
public class Sound {

    public AudioClip clip;
    public string ime;
    public bool loop;
    [Range(0, 3f)]
    public float volume;

    [Range(0, 2f)]
    public float pitch;

    [HideInInspector]
    public AudioSource source;

}
