using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObj : MonoBehaviour
{
    public GameObject objectToSpawn;
    public Transform spawnPoint;
    public int maxSpawnCount = 1;

    private int spawnCount = 0;

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Obj"))
        {
            Collider[] colls = Physics.OverlapSphere(transform.position, .3f);

            foreach(Collider coll in colls)
            {
                if (coll.CompareTag("Obj"))
                {
                    return;
                }
            }
        }

        Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation);
    }
}
