using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Plotka : MonoBehaviour
{
    public string promptMessage;
    private string text;
    public GameObject objToActive;
    public static bool toFeed;
    public TextMeshProUGUI destinationText;
    public CharacterMessage Roszkol;

    // Start is called before the first frame update
    void Start()
    {
        toFeed = false;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Interact()
    {

        switch (Language.language)
        {
            case Language_enum.Polish:
                text = "Nakarm P³otke (E)";
                break;
            case Language_enum.English:
                text = "Feed Roach (E)";
                break;
            case Language_enum.German:
                text = "Füttern Plötze (E)";
                break;
            case Language_enum.Spain:
                text = "alimentar Sardinilla(E)";
                break;
        }
        if (toFeed)
            promptMessage = text;
        else
            promptMessage = "";
    }
    public void Interact2()
    {
        if (toFeed)
        {
            objToActive.SetActive(true);
            gameObject.SetActive(false);
            Roszkol.place = Place_enum.Roszkol2;
            setText();
        }
    }
    private void setText()
    {

        switch (Language.language)
        {
            case Language_enum.Polish:
                destinationText.text = "znajdŸ Roszkola";
                break;
            case Language_enum.English:
                destinationText.text = "Find Roszkol";
                break;
            case Language_enum.German:
                destinationText.text = "Finde Roszkol";
                break;
            case Language_enum.Spain:
                destinationText.text = "Encuentra Roszkol";
                break;
        }
    }
}
