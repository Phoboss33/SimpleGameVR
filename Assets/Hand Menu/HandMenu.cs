using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandMenu : MonoBehaviour
{
    public Transform lefthand;
    public GameObject menu;

    private float one = 0.54f;
    private float two = 0.5f;
    private bool isZAxisUp = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.up.z > one && !isZAxisUp)
        {
            isZAxisUp = true;
            menu.SetActive(true);

        }
        else if (transform.up.z < two && isZAxisUp)
        {
            isZAxisUp = false;
            menu.SetActive(false);
        }
    }
}
