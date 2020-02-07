using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset : MonoBehaviour
{
    public GameObject resetAudio;
    public GameObject resetTracking;

    public void resetApp()
    {
        resetAudio.SetActive(false);
        resetTracking.SetActive(true);
        transform.parent.transform.position = new Vector3(1000, 1000, 1000);
    }
}
