using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class testGetStateDown : MonoBehaviour
{
    public SteamVR_Input_Sources handType;
    public SteamVR_Action_Boolean buttonAction;

    void Update()
    {
        if (buttonAction.GetStateDown(handType))
        {
            Debug.Log("Button pressed");
        }
    }
}
