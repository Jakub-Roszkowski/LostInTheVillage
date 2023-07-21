using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Glasses : MonoBehaviour
{
    public string promptMessage;
    private string text;
    public static bool toSee = false;
    public CharacterMessage Orzel;
    public TextMeshProUGUI destinationText;
    void Start()
    {
        toSee = false;
    }

    void Update()
    {
        
    }

    public void Interact()
    {

        switch (Language.language)
        {
            case Language_enum.Polish:
                text = "Podnieœ (E)";
                break;
            case Language_enum.English:
                text = "Pick up (E)";
                break;
            case Language_enum.German:
                text = "Abholen (E)";
                break;
            case Language_enum.Spain:
                text = "Levantar (E)";
                break;
        }
        if (toSee)
            promptMessage = text;
        else
            promptMessage = "";
    }

    public void Interact2()
    {
        if (toSee)
        {
            gameObject.SetActive(false);
            Orzel.place = Place_enum.Orzel_glasses;
            setText();
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
