using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterCaseCover : MonoBehaviour
{
    public GameObject caseCover;
    public static bool inPlace = false;

    public AudioSource audioSource;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CaseCover"))
        {
            audioSource.Play();
            caseCover.SetActive(true);
            inPlace = true;
            Destroy(other.gameObject);
            Renderer renderer = GetComponent<Renderer>();
            renderer.enabled = !renderer.enabled;
            TouchTrigger.isCaseCover = false;
        }
    }
}
