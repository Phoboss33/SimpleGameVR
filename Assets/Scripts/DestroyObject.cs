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
        
    }
}
