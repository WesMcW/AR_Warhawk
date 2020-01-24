using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingExtention : DefaultTrackableEventHandler
{
    public bool isOn = false, turnOn = false;
    public GameObject bench, sign, hawk;

    protected override void OnTrackingFound()
    {
        if (mTrackableBehaviour)
        {
            turnOn = true;

            var rendererComponents = mTrackableBehaviour.GetComponentsInChildren<Renderer>(true);
            var colliderComponents = mTrackableBehaviour.GetComponentsInChildren<Collider>(true);
            var canvasComponents = mTrackableBehaviour.GetComponentsInChildren<Canvas>(true);

            // Enable rendering:
            foreach (var component in rendererComponents)
                component.enabled = true;

            // Enable colliders:
            foreach (var component in colliderComponents)
                component.enabled = true;

            // Enable canvas':
            foreach (var component in canvasComponents)
                component.enabled = true;

            gameObject.SetActive(false);
        }
    }

    //protected override void OnTrackingLost()
    //{
        // do nothing
    //}

        /*
    private void Update()
    {
        if (turnOn && !isOn)
        {
            bench.SetActive(true);
            sign.SetActive(true);
            hawk.SetActive(true);
            isOn = true;
        }
    }*/
}
