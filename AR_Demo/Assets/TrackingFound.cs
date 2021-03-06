﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Vuforia;

public class TrackingFound : MonoBehaviour
{
    public GameObject imageTrack;
    public GameObject planeFinder;
    public GameObject canvas;
    public GameObject audioObject;
    public GameObject willie;
    public GameObject groundTxt;
    public GameObject willieTxt;

    private void Start()
    {
        //planeFinder.SetActive(false);
        audioObject.SetActive(false);
    }

    public void TrackingFoundMethod()
    {
        planeFinder.SetActive(true);
        imageTrack.SetActive(false);

        planeFinder.GetComponent<PlaneFinderBehaviour>().PerformHitTest( Vector2.zero);
        //planeFinder.GetComponent<PlaneFinderBehaviour>().PerformHitTest( new Vector2(0, 0 - (Screen.height * 0.25F)));
        //planeFinder.GetComponent<PlaneFinderBehaviour>().PerformHitTest( new Vector2(0, -362));

        //Event.PopEvent(planeFinder.GetComponent<AnchorInputListenerBehaviour>().OnInputReceivedEvent)
        //planeFinder.GetComponent<AnchorInputListenerBehaviour>().OnInputReceivedEvent

        //ExecuteEvents.Execute(planeFinder, planeFinder.GetComponent<PlaneFinderBehaviour>().PerformHitTest(Vector2.zero), planeFinder.GetComponent<AnchorInputListenerBehaviour>().OnInputReceivedEvent);
    }

    public void SwapText()
    {
        groundTxt.SetActive(false);
        willieTxt.SetActive(true);
    }

    public void OnObjectPlaced()
    {
        //planeFinder.SetActive(false);
        //planeFinder.GetComponent<AnchorInputListenerBehaviour>().enabled = false;

        canvas.SetActive(false);
        Invoke("startTalking", 0.9F);
        willie.GetComponent<Animator>().SetTrigger("Start");
        // start willie animation
        // when animation ends, reset things
    }

    void startTalking()
    {
        audioObject.SetActive(true);
    }
}
