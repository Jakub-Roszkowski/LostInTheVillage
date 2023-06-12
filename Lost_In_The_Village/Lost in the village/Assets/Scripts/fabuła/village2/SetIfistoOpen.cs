using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetIfistoOpen : MonoBehaviour
{
    public List<GameObject> targetObjects = new List<GameObject>();

    private bool ifistoOpen = false;
    wskazowka wskazowka;
    private void Start()
    {
        wskazowka wskazowka = GetComponent<wskazowka>(); // Pobieranie komponentu Pointer z obiektu
        ifistoOpen = wskazowka.ifistoOpen; // Pobieranie wartoœci IsOpen z komponentu
    }


    private void Update()
    {
        wskazowka = GetComponent<wskazowka>(); // Pobieranie komponentu Pointer z obiektu
        ifistoOpen = wskazowka.ifistoOpen; // Pobieranie wartoœci IsOpen z komponentu
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
                var targetComponent = targetObject.GetComponent<wskazowka>();

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
