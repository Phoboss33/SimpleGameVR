using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCPU : MonoBehaviour
{
    public GameObject prefabObj;
    public GameObject Trigger;
    public static bool inPlace = false;

    private void Start()
    {
        Trigger.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("CPU"))
        {
            Trigger.SetActive(true);
            inPlace = true;
            prefabObj.SetActive(true);
            Renderer renderer = GetComponent<Renderer>();
            renderer.enabled = !renderer.enabled;
            Destroy(other.gameObject);
        }
    }

}


