using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class DisableHints : MonoBehaviour
{

    void Update()
    {
        Teleport.instance.CancelTeleportHint();
    }

}
