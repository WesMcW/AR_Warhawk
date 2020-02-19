using System.Collections;
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

    private void Start()
    {
        planeFinder.SetActive(false);
        audioObject.SetActive(false);
    }

    public void TrackingFoundMethod()
    {
        canvas.SetActive(true);
        planeFinder.SetActive(true);
        imageTrack.SetActive(false);

        planeFinder.GetComponent<PlaneFinderBehaviour>().PerformHitTest( new Vector2(0, -362));

        //Event.PopEvent(planeFinder.GetComponent<AnchorInputListenerBehaviour>().OnInputReceivedEvent)
        //planeFinder.GetComponent<AnchorInputListenerBehaviour>().OnInputReceivedEvent

        //ExecuteEvents.Execute(planeFinder, planeFinder.GetComponent<PlaneFinderBehaviour>().PerformHitTest(Vector2.zero), planeFinder.GetComponent<AnchorInputListenerBehaviour>().OnInputReceivedEvent);
    }

    public void OnObjectPlaced()
    {
        //planeFinder.SetActive(false);
        planeFinder.GetComponent<AnchorInputListenerBehaviour>().enabled = false;

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
