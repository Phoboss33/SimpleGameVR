using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Valve.VR;

public class StartGame : MonoBehaviour
{
    public GameObject gameObject;
    public void LoadScene()
    {
        //SceneManager.LoadScene(1);
        SteamVR_LoadLevel.Begin("Main");
        //Destroy(gameObject);
    }
}
