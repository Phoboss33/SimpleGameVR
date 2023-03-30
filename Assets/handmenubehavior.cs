using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class handmenubehavior : MonoBehaviour
{
    public GameObject handMenu;
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        if (TriggerHandMenuHead.inHead)
        {
            handMenu.gameObject.SetActive(true);
        }
    }
}
