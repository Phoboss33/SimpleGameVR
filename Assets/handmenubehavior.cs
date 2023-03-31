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
    public GameObject textCPU_fan;
    public GameObject textFAN;
    public GameObject textPSU;
    public GameObject textSSD;

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
            textCPU_fan.SetActive(false);
            textFAN.SetActive(false);
            textPSU.SetActive(false);
            textSSD.SetActive(false);
        }
        else if (TouchTrigger.isMother)
        {
            textMother.SetActive(true);
            textDefault.SetActive(false);
            textProc.SetActive(false);
            textVideocard.SetActive(false);
            textRAM.SetActive(false);
            textCPU_fan.SetActive(false);
            textFAN.SetActive(false);
            textPSU.SetActive(false);
            textSSD.SetActive(false);
        }
        else if (TouchTrigger.isVideocard)
        {
            textVideocard.SetActive(true);
            textDefault.SetActive(false);
            textProc.SetActive(false);
            textMother.SetActive(false);
            textRAM.SetActive(false);
            textCPU_fan.SetActive(false);
            textFAN.SetActive(false);
            textPSU.SetActive(false);
            textSSD.SetActive(false);
        }
        else if (TouchTrigger.isRAM)
        {
            textRAM.SetActive(true);
            textVideocard.SetActive(false);
            textDefault.SetActive(false);
            textProc.SetActive(false);
            textMother.SetActive(false);
            textCPU_fan.SetActive(false);
            textFAN.SetActive(false);
            textPSU.SetActive(false);
            textSSD.SetActive(false);
        }
        else if (TouchTrigger.isCPU_fan)
        {
            textCPU_fan.SetActive(true);
            textRAM.SetActive(false);
            textVideocard.SetActive(false);
            textDefault.SetActive(false);
            textProc.SetActive(false);
            textMother.SetActive(false);
            textFAN.SetActive(false);
            textPSU.SetActive(false);
            textSSD.SetActive(false);
        }
        else if (TouchTrigger.isFAN)
        {
            textFAN.SetActive(true);
            textCPU_fan.SetActive(false);
            textRAM.SetActive(false);
            textVideocard.SetActive(false);
            textDefault.SetActive(false);
            textProc.SetActive(false);
            textMother.SetActive(false);
            textPSU.SetActive(false);
            textSSD.SetActive(false);
        }
        else if (TouchTrigger.isPSU)
        {
            textPSU.SetActive(true);
            textFAN.SetActive(false);
            textCPU_fan.SetActive(false);
            textRAM.SetActive(false);
            textVideocard.SetActive(false);
            textDefault.SetActive(false);
            textProc.SetActive(false);
            textMother.SetActive(false);
            textSSD.SetActive(false);
        }
        else if (TouchTrigger.isSSD)
        {
            textSSD.SetActive(true);
            textPSU.SetActive(false);
            textFAN.SetActive(false);
            textCPU_fan.SetActive(false);
            textRAM.SetActive(false);
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
            textCPU_fan.SetActive(false);
            textFAN.SetActive(false);
            textPSU.SetActive(false);
            textSSD.SetActive(false);
        }
    }
}
