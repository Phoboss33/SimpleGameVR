using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasterBehavior : MonoBehaviour
{
    public GameObject text;
    public GameObject EasseterEgg;
    public void OnButtonPress()
    {
        if (MoneyTrigger.isMoney)
        {
            text.SetActive(false);
            EasseterEgg.SetActive(true);
        }
    }
}
