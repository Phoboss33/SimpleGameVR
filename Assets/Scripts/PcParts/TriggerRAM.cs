using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRAM : MonoBehaviour
{
    public GameObject prefabObj;
    public GameObject Trigger;
    public static bool inPlace = false;
    public AudioSource audioSource;

    private void Start()
    {
        Trigger.SetActive(true);
    }


    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("RAM"))
        {
            audioSource.Play();
            inPlace = true;
            prefabObj.SetActive(true);
            Trigger.SetActive(false);
            Renderer renderer = GetComponent<Renderer>();
            renderer.enabled = !renderer.enabled;
            Destroy(other.gameObject);
            TouchTrigger.isRAM = false;
        }
    }
}
