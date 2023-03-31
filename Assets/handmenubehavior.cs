using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class handmenubehavior : MonoBehaviour
{
    public GameObject handMenu;

    public GameObject textProc;
    public GameObject textMother;
    public GameObject textVideocard;
    public GameObject textRAM;

    public GameObject textDefault;
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        if (TouchTrigger.isProc)
        {
            textProc.SetActive(true);
            textDefault.SetActive(false);
            textMother.SetActive(false);
            textVideocard.SetActive(false);
            textRAM.SetActive(false);
        }
        else if (TouchTrigger.isMother)
        {
            textMother.SetActive(true);
            textDefault.SetActive(false);
            textProc.SetActive(false);
            textVideocard.SetActive(false);
            textRAM.SetActive(false);
        }
        else if (TouchTrigger.isVideocard)
        {
            textVideocard.SetActive(true);
            textDefault.SetActive(false);
            textProc.SetActive(false);
            textMother.SetActive(false);
            textRAM.SetActive(false);
        }
        else if (TouchTrigger.isRAM)
        {
            textRAM.SetActive(true);
            textVideocard.SetActive(false);
            textDefault.SetActive(false);
            textProc.SetActive(false);
            textMother.SetActive(false);
        }
        else 
        {
            textDefault.SetActive(true);
            textProc.SetActive(false);
            textRAM.SetActive(false);
            textMother.SetActive(false);
            textVideocard.SetActive(false);
        }
    }
}
