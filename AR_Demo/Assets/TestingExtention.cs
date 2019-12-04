using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingExtention : DefaultTrackableEventHandler
{
    public bool isOn = false;
    public GameObject cube;

    protected override void OnTrackingFound()
    {
        if (mTrackableBehaviour)
        {
            isOn = true;

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
        }
    }

    private void Update()
    {
        if (isOn && !cube.activeSelf) cube.SetActive(true);
    }
}
