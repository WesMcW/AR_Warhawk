using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioController : MonoBehaviour
{
    public AudioSource source;
    GameObject willy;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        playWillyAudio();
        willy = GameObject.Find("WillyW"); //finds game object with specified name
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //

    /// <summary>
    /// Call this method to play clip
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
