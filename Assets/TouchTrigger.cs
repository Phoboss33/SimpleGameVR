using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        if (other.gameObject.CompareTag("RAM"))     // фикс бага с оперативкой, возможно добавить теги ram1 и ram2
        {
            isRAM = true;
        }
        if (other.gameObject.CompareTag("CPU_cooler"))
        {
            isCPU_fan = true;
        }
        if (other.gameObject.CompareTag("FAN"))
        {
            isFAN = true;
        }
        if (other.gameObject.CompareTag("PSU"))
        {
            isPSU = true;
        }
        if (other.gameObject.CompareTag("SSD"))
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
        if (other.gameObject.CompareTag("RAM"))
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



