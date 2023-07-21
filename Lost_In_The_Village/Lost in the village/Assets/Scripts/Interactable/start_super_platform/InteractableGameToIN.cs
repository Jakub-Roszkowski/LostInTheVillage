using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableGameToIN : MonoBehaviour
{

    public string promptMessage;
    private string text;
    public bool to_see = true;


    private GameOpenerSuperPlatform game_opener;

    void Start()
    {
        game_opener = GetComponent<GameOpenerSuperPlatform>();
        to_see = true;
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

    public void Interact2()
    {
        if (to_see)
        {
            game_opener.startGame();
        }
    }
}
