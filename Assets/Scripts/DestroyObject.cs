using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("VideoCard"))
        {
            TriggerSpawnGPU.spawnCount--;
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("Motherboard"))
        {
            TriggerSpawnMotherboard.spawnCount--;
            Destroy(other.gameObject);

            if (TriggerCPU.inPlace == true)
            {
                TriggerCPU.inPlace = false;
                SpawnCPU.spawnCount--;
            }
            if (TriggerGPU.inPlace == true)
            {
                TriggerGPU.inPlace = false;
                TriggerSpawnGPU.spawnCount--;
            }
            if (TriggerCPU_cooler.inPlace == true)
            {
                TriggerCPU_cooler.inPlace = false;
                SpawnCPU_cooler.spawnCount--;
            }
            if (TriggerRAM.inPlace == true)
            {
                TriggerRAM.inPlace = false;
                SpawnRAM.spawnCount--;
            }
            if (TriggerRightRAM.inPlace == true)
            {
                TriggerRightRAM.inPlace = false;
                SpawnRAM.spawnCount--;
            }
        }
        if (other.gameObject.CompareTag("PSU"))
        {
            SpawnPSU.spawnCount--;
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("SSD"))
        {
            SpawnSSD.spawnCount--;
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("RAM"))
        {
            SpawnRAM.spawnCount--;
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("CPU_cooler"))
        {
            SpawnCPU_cooler.spawnCount--;
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("FAN"))
        {
            SpawnFan.spawnCount--;
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("CPU"))
        {
            SpawnCPU.spawnCount--;
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("CaseCover"))
        {
            SpawnCaseCover.spawnCount--;
            Destroy(other.gameObject);
        }

        
    }
}
