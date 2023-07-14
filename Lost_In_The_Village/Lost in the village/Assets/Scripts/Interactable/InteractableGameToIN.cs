using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableGameToIN : MonoBehaviour
{

    public string promptMessage;
    private string text;
    public bool to_see = true;


    // Start is called before the first frame update
    void Start()
    {
        
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
                text = "Zagraj (E)";
                break;
            case Language_enum.English:
                text = "Play (E)";
                break;
            case Language_enum.German:
                text = "Spielen (E)";
                break;
            case Language_enum.Spain:
                text = "Jugar (E)";
                break;
        }

        if (to_see)
            promptMessage = text;
        else
            promptMessage = "";
    }
}
