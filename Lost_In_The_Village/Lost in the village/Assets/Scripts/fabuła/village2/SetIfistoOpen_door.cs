using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetIfistoOpen_door : MonoBehaviour
{
    public List<GameObject> targetObjects = new List<GameObject>();

    private void Start()
    {

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

                SetIfistoOpenValue();

        }
    }




    private void SetIfistoOpenValue()
    {
        foreach (var targetObject in targetObjects)
        {
            if (targetObject != null)
            {
                var targetComponent = targetObject.GetComponent<Door_evacuation>();

                if (targetComponent != null)
                {
                    targetComponent.ifistoOpen = true;
                }
            }
        }
    }
}
