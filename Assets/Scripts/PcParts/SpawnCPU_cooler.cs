using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCPU_cooler : MonoBehaviour
{
    public GameObject objectToSpawn;
    public int maxSpawnCount;

    public static int spawnCount = 0;

    private void Start()
    {
        spawnCount = 0;
    }

    private void Update()
    {
        // Если максимальное количество объектов не достигнуто
        if (spawnCount < maxSpawnCount)
        {
            // Создаем новый объект в позиции триггера
            Instantiate(objectToSpawn, transform.position, transform.rotation);
            spawnCount++;
        }

    }
}
