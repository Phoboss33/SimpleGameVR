using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTrigger : MonoBehaviour
{
    public static bool inProc = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("CPU"))
        {
            inProc = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("CPU"))
        {
            inProc = false;
        }
    }
}



