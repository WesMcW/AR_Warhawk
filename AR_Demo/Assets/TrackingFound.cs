using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackingFound : MonoBehaviour
{
    public GameObject enablePlace;
    public GameObject enableCanvas;
    public GameObject disableObject;

    public void TrackingFoundMethod()
    {
        enableCanvas.SetActive(true);
        enablePlace.SetActive(true);
    }

    public void OnObjectPlaced()
    {
        enablePlace.SetActive(false);
        enableCanvas.SetActive(false);
    }
}
