using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerHandMenuHead : MonoBehaviour
{
    public GameObject handMenu;

    public static bool inHead = true;
    public GameObject head;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Hand"))
        {
            inHead = true;
            handMenu.SetActive(true);
            //Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("Hat"))
        {
            head.SetActive(true);
            Destroy(other.gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Hand"))
        {
            handMenu.SetActive(false);
        }
    }

   /* private void Update()
    {
        if (inHead)
            handMenu.SetActive(true);
        else if (!inHead)
            handMenu.SetActive(false);
    }*/
}
