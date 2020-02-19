using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reset : MonoBehaviour
{
    public GameObject resetAudio;
    public GameObject resetTracking;

    public void resetApp()
    {
        SceneManager.LoadScene(0);

        resetAudio.SetActive(false);
        resetTracking.SetActive(true);
        transform.parent.transform.position = new Vector3(1000, 1000, 1000);
    }
}
