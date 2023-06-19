using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Set_ifisto_Open_door1 : MonoBehaviour
{
    public List<GameObject> targetObjects = new List<GameObject>();

    private bool ifistoOpen=false;
    Hint hint;

    private void Start()
    {
        hint = GetComponent<Hint>();
        ifistoOpen = hint.ifistoOpen;

    }
    private void Update()
    {
        hint = GetComponent<Hint>(); 
        ifistoOpen = hint.ifistoOpen;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")&& ifistoOpen)
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
                var targetComponent = targetObject.GetComponent<LoadSceneOnTrigger>();

                if (targetComponent != null)
                {
                    targetComponent.ifistoOpen = true;
                }
            }
        }
    }
}
