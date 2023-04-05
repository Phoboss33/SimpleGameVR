using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSSD : MonoBehaviour
{
    public GameObject SSD;
    public static bool inPlace = false;

    public AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SSD"))
        {
            audioSource.Play();
            SSD.SetActive(true);
            inPlace = true;
            Destroy(other.gameObject);
            Renderer renderer = GetComponent<Renderer>();
            renderer.enabled = !renderer.enabled;
            TouchTrigger.isSSD = false;
        }
    }
}
