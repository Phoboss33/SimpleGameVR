using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestStartGame : MonoBehaviour
{
    public GameObject player;

    private void Start()
    {
        Instantiate(player);
    }
}
