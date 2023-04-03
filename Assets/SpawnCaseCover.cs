using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCaseCover : MonoBehaviour
{
    public GameObject objectToSpawn;
    public int maxSpawnCount;

    public static int spawnCount = 0;

    public static bool CheckObjInCase()
    {
        if (TriggerFan.inPlace && TriggerRAM.inPlace && TriggerPSU.inPlace
            && TriggerCPU.inPlace && TriggerGPU.inPlace && TriggerCPU_cooler.inPlace
            && TriggerRAM.inPlace && TriggerRightRAM.inPlace && TriggerSSD.inPlace
            && MotherInCase.inCase)
            return true;

        return false;
    }

    private void Update()
    {
        // Если максимальное количество объектов не достигнуто
        if (spawnCount < maxSpawnCount && CheckObjInCase())
        {
            // Создаем новый объект в позиции триггера
            Instantiate(objectToSpawn, transform.position, transform.rotation);
            spawnCount++;
        }

    }
}
