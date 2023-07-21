using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InteractableLaptop : MonoBehaviour
{
    public string promptMessage;
    private string text;
    private string text2;

    public GameObject[] objectsToDeactivate;
    public static bool toSee = false;

    public CharacterMessage Orzel;
    public TextMeshProUGUI destinationText;


    private void Start()
    {
        toSee = false;
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

    public void Interact()
    {

        switch (Language.language)
        {
            case Language_enum.Polish:
                text = "Uruchom (E)";
                break;
            case Language_enum.English:
                text = "Run (E)";
                break;
            case Language_enum.German:
                text = "Laufen (E)";
                break;
            case Language_enum.Spain:
                text = "Correr (E)";
                break;
        }

        switch (Language.language)
        {
            case Language_enum.Polish:
                text2 = "Niedostêpne";
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
            DisableObjects();
            Orzel.place = Place_enum.Orzel_laptop;
            setText();
            DoorEvacuation.toSee = true;
            toSee = false;
        }
    }



    private void setText()
    {

        switch (Language.language)
        {
            case Language_enum.Polish:
                destinationText.text = "Orze³";
                break;
            case Language_enum.English:
                destinationText.text = "Eagle";
                break;
            case Language_enum.German:
                destinationText.text = "Adler";
                break;
            case Language_enum.Spain:
                destinationText.text = "Águila";
                break;
        }
    }
}
