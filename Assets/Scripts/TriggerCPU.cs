using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TriggerCPU : MonoBehaviour
{
    public GameObject prefabObj;
    public GameObject Trigger;
    public static bool inPlace = false;
    public AudioSource audioSource; 

    private void Start()
    {
        Trigger.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("CPU"))
        {
            audioSource.Play();
            Trigger.SetActive(true);
            inPlace = true;
            prefabObj.SetActive(true);
            Renderer renderer = GetComponent<Renderer>();
            renderer.enabled = !renderer.enabled;
            Destroy(other.gameObject);
            TouchTrigger.isProc = false;
        }
    }

}


