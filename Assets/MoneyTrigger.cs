using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyTrigger : MonoBehaviour
{
    public static bool isMoney = false;
    public GameObject GameObject;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Money"))
        {
            Destroy(other.gameObject);
            isMoney = true;
            GameObject.SetActive(true);
        }
    }
}
