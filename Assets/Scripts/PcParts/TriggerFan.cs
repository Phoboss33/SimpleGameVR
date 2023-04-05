using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFan : MonoBehaviour
{
    public GameObject fan;
    public static bool inPlace = false;

    public AudioSource audioSource;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FAN"))
        {
            audioSource.Play();
            fan.SetActive(true);
            inPlace = true;
            Destroy(other.gameObject);
            Renderer renderer = GetComponent<Renderer>();
            renderer.enabled = !renderer.enabled;
            TouchTrigger.isFAN = false;
        }
    }
}
