using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeskBehaviorScript : MonoBehaviour
{
    public GameObject tutorDesk;
    public GameObject monitor;

    public void PressButton()
    {
        if (SpawnCaseCover.CheckObjInCase())
        {
            tutorDesk.SetActive(false);
            monitor.SetActive(true);
        }

    }
}
