using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disable : MonoBehaviour
{
    public GameObject[] objectsToDeactivate;
    public bool ifistoOpen = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (ifistoOpen)
            {
                DisableObjects();
            }
        }
    }

    private void DisableObjects()
    {
        foreach (var obj in objectsToDeactivate)
        {
            if (obj != null)
            {
                obj.SetActive(false);
            }
        }
    }
}
