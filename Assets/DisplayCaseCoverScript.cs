using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayCaseCoverScript : MonoBehaviour
{
    public GameObject caseCover;
    void Update()
    {
        if (SpawnCaseCover.CheckObjInCase())
            caseCover.SetActive(true);
    }
}
