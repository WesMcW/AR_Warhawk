using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackingFound : MonoBehaviour
{
    public GameObject disableImageTrack;
    public GameObject enablePlace;
    public GameObject enableCanvas;
    public GameObject startAudio;
    public GameObject willie;

    private void Start()
    {
        enablePlace.SetActive(false);
        startAudio.SetActive(false);
    }

    public void TrackingFoundMethod()
    {
        enableCanvas.SetActive(true);
        enablePlace.SetActive(true);
        disableImageTrack.SetActive(false);
    }

    public void OnObjectPlaced()
    {
        enablePlace.SetActive(false);
        enableCanvas.SetActive(false);
        startAudio.SetActive(true);
        willie.GetComponent<Animator>().SetTrigger("Start");
        // start willie animation
        // when animation ends, reset things
    }
}
