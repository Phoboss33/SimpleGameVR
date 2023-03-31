using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCPU_cooler : MonoBehaviour
{
    public GameObject prefabObj;
    public GameObject Trigger;
    public static bool inPlace = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("CPU_cooler") && (TriggerCPU.inPlace == true))
        {
            
            inPlace = true;
            prefabObj.SetActive(true);
            Renderer renderer = GetComponent<Renderer>();
            renderer.enabled = !renderer.enabled;
            Destroy(other.gameObject);
            TouchTrigger.isCPU_fan = false;
        }
    }
}
