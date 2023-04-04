using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterCaseCover : MonoBehaviour
{
    public GameObject caseCover;
    public static bool inPlace = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CaseCover"))
        {
            caseCover.SetActive(true);
            inPlace = true;
            Destroy(other.gameObject);
            Renderer renderer = GetComponent<Renderer>();
            renderer.enabled = !renderer.enabled;
            TouchTrigger.isCaseCover = false;
        }
    }
}
