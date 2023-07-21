using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable_game_console : MonoBehaviour
{
    //message displayed to player when looking at an interactable.
    public string promptMessage;
    //this function will be called from our player.
    private void Update()
    {

    }
    public void BaseInteract1()
    {
        switch (Language.language)
        {
            case Language_enum.Polish:
                promptMessage = "Zagraj na konsoli (E)";
                break;
            case Language_enum.English:
                promptMessage = "Play on gameconsole (E)";
                break;
            case Language_enum.German:
                promptMessage = "Spielen Sie auf der Spielekonsole. (E)";
                break;
            case Language_enum.Spain:
                promptMessage = "Juega en la consola de juegos. (E)";
                break;
        }
    }
    public void BaseInteract()
    {
        Interact();
    }
    protected virtual void Interact()
    {

    }
    protected virtual void Interact1()
    {

    }
}
