using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR;

public class LoadSceneScript : MonoBehaviour
{
    public string levelName;

    public void PressButton()
    {
        SteamVR_LoadLevel.Begin("Main");
    }
}
