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
        promptMessage = "Zagraj w gre (E)";
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
