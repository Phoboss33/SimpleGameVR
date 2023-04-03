using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterCaseTrigger : MonoBehaviour
{
    public GameObject motherBoard;
    public GameObject proc;
    public GameObject cpu_cooler;
    public GameObject videocard;
    public GameObject ram_l;
    public GameObject ram_r;

    public GameObject cpu_cooler_Trigger;
    public GameObject cpuTrigger;
    public GameObject ramTrigger_r;
    public GameObject ramTrigger_l;

    public static bool inPlace = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Motherboard"))
        {
            motherBoard.SetActive(true);
            inPlace = true;
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

        if (TriggerRightRAM.inPlace == true)
        {
            ram_r.SetActive(true);
            ramTrigger_r.SetActive(false);
        }

        if (TriggerRAM.inPlace == true)
        {
            ram_l.SetActive(true);
            ramTrigger_l.SetActive(false);
        }
    }
}
// доделать триггеры для остальных компонетнов.
