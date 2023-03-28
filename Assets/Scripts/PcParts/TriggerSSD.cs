using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSSD : MonoBehaviour
{
    public GameObject SSD;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SSD"))
        {
            SSD.SetActive(true);
            Destroy(other.gameObject);
            Renderer renderer = GetComponent<Renderer>();
            renderer.enabled = !renderer.enabled;
        }
    }
}
