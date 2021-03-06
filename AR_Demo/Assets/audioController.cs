﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioController : MonoBehaviour
{
    public AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        playWillyAudio();
    }

    // Update is called once per frame
    void Update()
    {
   
    }

    /// <summary>
    /// Call this method to play Willy audio clip.
    /// Only plays if clip is not already playing.
    /// </summary>
    public void playWillyAudio()
    {
        if (!source.isPlaying)
            source.Play();
    }
    //plays clip when object is enabled
    private void OnEnable()
    {
        playWillyAudio();
    }
}
