using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour {

    public Sound[] zvukovi;

    void Awake()
    {
        foreach(Sound zvu in zvukovi)
        {
            zvu.source =gameObject.AddComponent<AudioSource>();
            zvu.source.clip = zvu.clip;
            zvu.source.volume = zvu.volume;
            zvu.source.pitch = zvu.pitch;
            zvu.source.loop = zvu.loop;
        }
    }

    public void Sviraj (string ime0)
    {
        Sound s = Array.Find(zvukovi, z => z.ime == ime0);
        s.source.Play();
    }
}
