using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class TriggerText : MonoBehaviour
{
    public TextMeshProUGUI textCPU;
    public TextMeshProUGUI textCPU_cooler;
    public TextMeshProUGUI textRAM;
    public TextMeshProUGUI textGPU;
    public TextMeshProUGUI textPSU;
    public TextMeshProUGUI textMotherboard;
    public TextMeshProUGUI textFan;
    public TextMeshProUGUI textSSD;

    private void Update()
    {
        // ��������� 
        if (TriggerCPU.inPlace)
        {
            textCPU.color = Color.green;
        }
        else
        {
            textCPU.color = Color.red;      // ./chat -t 10
        }

        // ����� ��� ����������
        if (TriggerCPU_cooler.inPlace)
        {
            textCPU_cooler.color = Color.green;
        }
        else
        {
            textCPU_cooler.color = Color.red;
        }

        // ���
        if ((TriggerRAM.inPlace) || (TriggerRightRAM.inPlace))
        {
            textRAM.color = Color.green;
        }
        else
        {
            textRAM.color = Color.red;
        }

        // ����������
        if (TriggerGPU.inPlace)
        {
            textGPU.color = Color.green;
        }
        else
        {
            textGPU.color = Color.red;
        }

        // ���������
        if (EnterCaseTrigger.inPlace)
        {
            textMotherboard.color = Color.green;
        }
        else
        {
            textMotherboard.color = Color.red;
        }

        // �����
        if (TriggerFan.inPlace)
        {
            textFan.color = Color.green;
        }
        else
        {
            textFan.color = Color.red;
        }

        // ��
        if (TriggerPSU.inPlace)
        {
            textPSU.color = Color.green;
        }
        else
        {
            textPSU.color = Color.red;
        }

        // SSD
        if (TriggerSSD.inPlace)
        {
            textSSD.color = Color.green;
        }
        else
        {
            textSSD.color = Color.red;
        }
    }
}
