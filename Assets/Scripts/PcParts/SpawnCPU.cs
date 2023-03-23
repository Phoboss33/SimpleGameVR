using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCPU : MonoBehaviour
{
    public GameObject objectToSpawn;
    public int maxSpawnCount;

    public static int spawnCount = 0;

    private void Update()
    {
        // ���� ������������ ���������� �������� �� ����������
        if (spawnCount < maxSpawnCount)
        {
            // ������� ����� ������ � ������� ��������
            Instantiate(objectToSpawn, transform.position, transform.rotation);
            spawnCount++;
        }

    }
}
