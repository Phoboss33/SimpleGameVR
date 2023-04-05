using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("VideoCard"))
        {
            audioSource.Play();
            TriggerSpawnGPU.spawnCount--;
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("Motherboard"))
        {
            audioSource.Play();
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
            audioSource.Play();
            SpawnPSU.spawnCount--;
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("SSD"))
        {
            audioSource.Play();
            SpawnSSD.spawnCount--;
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("RAM"))
        {
            audioSource.Play();
            SpawnRAM.spawnCount--;
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("CPU_cooler"))
        {
            audioSource.Play();
            SpawnCPU_cooler.spawnCount--;
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("FAN"))
        {
            audioSource.Play();
            SpawnFan.spawnCount--;
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("CPU"))
        {
            audioSource.Play();
            SpawnCPU.spawnCount--;
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("CaseCover"))
        {
            audioSource.Play();
            SpawnCaseCover.spawnCount--;
            Destroy(other.gameObject);
        }

        
    }
}
