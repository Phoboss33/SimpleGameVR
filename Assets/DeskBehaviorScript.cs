using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeskBehaviorScript : MonoBehaviour
{
    public GameObject tutorDesk;
    public GameObject monitor;
    public AudioSource audioSource;

    private ushort buttonPressCount;

    public void PressButton()
    {
        if (SpawnCaseCover.CheckObjInCase() && (buttonPressCount % 2 == 0) )
        {
            tutorDesk.SetActive(false);
            monitor.SetActive(true);
            buttonPressCount++;
            audioSource.Play();
        }
        else if (SpawnCaseCover.CheckObjInCase() && (buttonPressCount % 2 != 0))
        {
            tutorDesk.SetActive(true);
            monitor.SetActive(false);
            buttonPressCount++;
            audioSource.Stop();
        }

    }
}
