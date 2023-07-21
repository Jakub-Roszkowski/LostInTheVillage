using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DoorEvacuation : MonoBehaviour
{

    public string promptMessage;
    private string text;
    private string text2;


    public GameObject objectToActivate;
    public GameObject[] objectsToDeactivate;
    public static bool toSee = false;


    private void Start()
    {
        toSee = false;
    }

    public void Interact()
    {

        switch (Language.language)
        {
            case Language_enum.Polish:
                text = "Otwórz bramê (E)";
                break;
            case Language_enum.English:
                text = "Open the gate (E)";
                break;
            case Language_enum.German:
                text = "öffne das Tor (E)";
                break;
            case Language_enum.Spain:
                text = "abre la puerta (E)";
                break;
        }

        switch (Language.language)
        {
            case Language_enum.Polish:
                text2 = "JSOS jeszcze nie dzia³a";
                break;
            case Language_enum.English:
                text2 = "Not available";
                break;
            case Language_enum.German:
                text2 = "Nicht verfügbar";
                break;
            case Language_enum.Spain:
                text2 = "No disponible)";
                break;
        }

        if (toSee)
            promptMessage = text;
        else
            promptMessage = text2;
    }

    public void Interact2()
    {
        if (toSee)
        {
            ActivateObjects();
        }
    }




    private void ActivateObjects()
    {
        if (objectToActivate != null)
        {
            objectToActivate.SetActive(true);
        }

        foreach (var obj in objectsToDeactivate)
        {
            if (obj != null)
            {
                obj.SetActive(false);
            }
        }
    }

}
