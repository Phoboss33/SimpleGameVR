using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPSU : MonoBehaviour
{
    public GameObject PSU;
    public GameObject backWall;
    public static bool inPlace = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PSU"))
        {
            PSU.SetActive(true);
            inPlace = true;
            backWall.SetActive(true);
            Destroy(other.gameObject);
            Renderer renderer = GetComponent<Renderer>();
            renderer.enabled = !renderer.enabled;
        }
    }
}
