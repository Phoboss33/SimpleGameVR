using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sript : MonoBehaviour
{
    public GameObject perfab;
    public Transform pos;

    private List<GameObject> objects = new List<GameObject> ();

    public void CreateObject()
    {
        GameObject newObj = Instantiate(perfab, pos.position, pos.rotation);
        objects.Add(newObj);
    }

    public void DestroyObjects()
    {
        foreach (GameObject obj in objects)
        {
            Destroy(obj);
        }

        objects.Clear ();
    }
}
