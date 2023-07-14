using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable_donut : MonoBehaviour
{
    //message displayed to player when looking at an interactable.
    public string promptMessage;
    //this function will be called from our player.
    private int value = 20;
    private string text;

    private void Update()
    {

    }
    public void BaseInteract1()
    {
        if (Pause.currentLevel == Level.Easy)
        {
            value = 30;
        }
        if (Pause.currentLevel == Level.Medium)
        {
            value = 20;
        }
        if (Pause.currentLevel == Level.Hard)
        {
            value = 5;
        }



        if (Language.language == Language_enum.Polish)
        {
            text = "Dostajesz";
        }
        else if (Language.language == Language_enum.English)
        {
            text = "You get";
        }
        else if (Language.language == Language_enum.German)
        {
            text = "Du erhältst";
        }
        else if (Language.language == Language_enum.Spain)
        {
            text = "Usted obtiene";
        }
        promptMessage = text + " " + value + " HP (E)";
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