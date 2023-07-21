using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableBackup : MonoBehaviour
{
    public string promptMessage;
    private string text;
    private string text2;
    public static bool toSee = false;


    private GameOpenerPuzzle game_opener;

    void Start()
    {
        game_opener = GetComponent<GameOpenerPuzzle>();
        toSee = false;
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
                text2 = "No disponible";
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
            game_opener.startGame();
        }
    }
}
