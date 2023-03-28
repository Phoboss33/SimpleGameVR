using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterCaseTrigger : MonoBehaviour
{
    public GameObject motherBoard;
    public GameObject proc;
    public GameObject cpu_cooler;
    public GameObject videocard;
    public GameObject ramRight;
    public GameObject ramLeft;
    public GameObject cpu_cooler_Trigger;
    public GameObject cpuTrigger;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Motherboard"))
        {
            motherBoard.SetActive(true);
            Destroy(other.gameObject);
            Renderer renderer = GetComponent<Renderer>();
            renderer.enabled = !renderer.enabled;
        }

        if (TriggerCPU.inPlace == true)
        {
            proc.SetActive(true);
            //cpuTrigger.SetActive(true);
            cpuTrigger.SetActive(false);
        }

        if (TriggerGPU.inPlace == true)
            videocard.SetActive(true);

        if (TriggerCPU_cooler.inPlace == true)
        {
            cpu_cooler.SetActive(true);
            cpu_cooler_Trigger.SetActive(false);
        }
    }
}
// доделать триггеры для остальных компонетнов.
