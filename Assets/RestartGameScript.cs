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
            if (obj.tag == "Respawn")
            {
                Destroy(obj);
            }
            
            if (obj.tag == "Motherboard")
            {
                Destroy(obj);
            }
        }

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
        EnterCaseCover.inPlace = false;

        SpawnCaseCover.spawnCount = 0;

        //SpawnCPU.spawnCount--;
    }
}
