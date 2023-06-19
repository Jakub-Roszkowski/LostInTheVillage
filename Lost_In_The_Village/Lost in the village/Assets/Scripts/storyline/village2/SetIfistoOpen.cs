using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetIfistoOpen : MonoBehaviour
{
    public List<GameObject> targetObjects = new List<GameObject>();

    private bool ifistoOpen = false;
    Hint hint;
    private void Start()
    {
        Hint wskazowka = GetComponent<Hint>(); 
        ifistoOpen = wskazowka.ifistoOpen;
    }


    private void Update()
    {
        hint = GetComponent<Hint>();
        ifistoOpen = hint.ifistoOpen;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && ifistoOpen)
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
                var targetComponent = targetObject.GetComponent<Hint>();

                if (targetComponent != null)
                {
                    targetComponent.ifistoOpen = true;
                }
                var targetComponent2 = targetObject.GetComponent<disable>();

                if (targetComponent2 != null)
                {
                    targetComponent2.ifistoOpen = true;
                }
            }
        }
    }
}
