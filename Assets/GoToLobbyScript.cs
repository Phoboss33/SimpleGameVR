using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR;

public class GoToLobbyScript : MonoBehaviour
{
    public void Transition()
    {
        SteamVR_LoadLevel.Begin("Lobby");
    }
}
