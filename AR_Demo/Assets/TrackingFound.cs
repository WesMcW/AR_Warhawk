using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackingFound : MonoBehaviour
{
    public GameObject enableObject;

    public void TrackingFoundMethod()
    {
        enableObject.SetActive(true);
    }
}
