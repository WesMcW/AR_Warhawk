using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioController : MonoBehaviour
{
    public AudioSource clip;
    GameObject willy;
    // Start is called before the first frame update
    void Start()
    {
        clip = GetComponent<AudioSource>();
        playWillyAudio();
        willy = GameObject.Find("WillyW"); //finds game object with specified name
   

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //call to play clip
    public void playWillyAudio()
    {
        if (!clip.isPlaying)
            clip.Play();
    }
    //plays clip when object is enabled
    private void OnEnable()
    {
        playWillyAudio();
    }
    private void OnDisable()
    {
        clip.Stop();
    }
}
