using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class MotherInCase : MonoBehaviour
{
    public Transform motherBoard;
    public GameObject motgerBoardObj;
    public static bool inCase = false;

    public AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Motherboard"))
        {
            audioSource.Play();
            other.transform.position = new Vector3(transform.position.x - 0f, transform.position.y - 0.35f, transform.position.z - 0.16f);
            other.transform.rotation = Quaternion.Euler(0f, 0f, 0f);

            other.gameObject.GetComponent<Rigidbody>().detectCollisions = false;
            other.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            Destroy(other);
            TouchTrigger.isMother = false;
            inCase = true;

            //motherBoard.gameObject.GetComponent<>()

        }
    }
}
