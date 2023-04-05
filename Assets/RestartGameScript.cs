using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Valve.VR;

public class RestartGameScript : MonoBehaviour
{
    public void ReloadScene()
    {
        GameObject[] allObjects = GameObject.FindObjectsOfType<GameObject>();
        foreach (GameObject obj in allObjects)
        {
            if ((obj.tag == "Respawn") || (obj.tag == "Motherboard") || (obj.tag == "VideoCard") || (obj.tag == "PSU") || (obj.tag == "SSD") || (obj.tag == "RAM") || (obj.tag == "RAM")
                 || (obj.tag == "CPU_cooler") || (obj.tag == "FAN") || (obj.tag == "CPU") || (obj.tag == "CaseCover"))
            {
                Destroy(obj);
            }

            if (obj.tag == "Hat")
                obj.SetActive(false);

            if (obj.tag == "Money")
                obj.SetActive(false);

/*            if (obj.tag == "Hat")
            {
                Destroy(obj);
            }
            
            if (obj.tag == "Motherboard")
            {
                Destroy(obj);
            }*/
        }

        MoneyTrigger.isMoney = false;

        SteamVR_LoadLevel.Begin(SceneManager.GetActiveScene().name);

        TriggerCPU.inPlace = false;
        TriggerCPU_cooler.inPlace = false;
        TriggerFan.inPlace = false;
        TriggerGPU.inPlace = false;
        TriggerPSU.inPlace = false;
        TriggerRAM.inPlace = false;
        TriggerRightRAM.inPlace = false;
        TriggerSSD.inPlace = false;
        MotherInCase.inCase = false;
        EnterCaseTrigger.inPlace = false;
        EnterCaseCover.inPlace = false;

        SpawnCaseCover.spawnCount = 0;

        //SpawnCPU.spawnCount--;
    }
}
