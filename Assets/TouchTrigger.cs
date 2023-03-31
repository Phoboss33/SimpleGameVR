using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTrigger : MonoBehaviour
{
    public static bool isProc = false;
    public static bool isMother = false;
    public static bool isVideocard = false;
    public static bool isRAM = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("CPU"))
        {
            isProc = true;
        }
        if (other.gameObject.CompareTag("Motherboard"))
        {
            isMother = true;
        }
        if (other.gameObject.CompareTag("VideoCard"))
        {
            isVideocard = true;
        }
        if (other.gameObject.CompareTag("RAM"))
        {
            isRAM = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("CPU"))
        {
            isProc = false;
        }
        if (other.gameObject.CompareTag("Motherboard"))
        {
            isMother = false;
        }
        if (other.gameObject.CompareTag("VideoCard"))
        {
            isVideocard = false;
        }
        if (other.gameObject.CompareTag("RAM"))
        {
            isRAM = false;
        }
    }
}



