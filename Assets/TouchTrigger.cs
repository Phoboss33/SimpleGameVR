using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class TouchTrigger : MonoBehaviour
{
    public static bool isProc = false;
    public static bool isMother = false;
    public static bool isVideocard = false;
    public static bool isRAM = false;
    public static bool isCPU_fan = false;
    public static bool isFAN = false;
    public static bool isPSU = false;
    public static bool isSSD = false;

    public SteamVR_Input_Sources handType;
    public SteamVR_Action_Boolean buttonAction;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("CPU") && buttonAction.GetStateDown(handType))
        {
            isProc = true;
        }
        if (other.gameObject.CompareTag("Motherboard") && buttonAction.GetStateDown(handType))
        {
            isMother = true;
        }
        if (other.gameObject.CompareTag("VideoCard") && buttonAction.GetStateDown(handType))
        {
            isVideocard = true;
        }
        if (other.gameObject.CompareTag("RAM") && buttonAction.GetStateDown(handType) )    
        {
            isRAM = true;
        }
        if (other.gameObject.CompareTag("CPU_cooler") && buttonAction.GetStateDown(handType))
        {
            isCPU_fan = true;
        }
        if (other.gameObject.CompareTag("FAN") && buttonAction.GetStateDown(handType))
        {
            isFAN = true;
        }
        if (other.gameObject.CompareTag("PSU") && buttonAction.GetStateDown(handType))
        {
            isPSU = true;
        }
        if (other.gameObject.CompareTag("SSD") && buttonAction.GetStateDown(handType))
        {
            isSSD = true;
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
        if (other.gameObject.CompareTag("RAM") && buttonAction.GetStateUp(handType))
        {
            isRAM = false;
        }

        if (other.gameObject.CompareTag("CPU_cooler"))
        {
            isCPU_fan = false;
        }

        if (other.gameObject.CompareTag("FAN"))
        {
            isFAN = false;
        }

        if (other.gameObject.CompareTag("PSU"))
        {
            isPSU = false;
        }

        if (other.gameObject.CompareTag("SSD"))
        {
            isSSD = false;
        }
    }
}



