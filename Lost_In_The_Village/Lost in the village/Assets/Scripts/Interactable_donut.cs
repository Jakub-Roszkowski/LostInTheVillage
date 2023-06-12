using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable_donut : MonoBehaviour
{
    //message displayed to player when looking at an interactable.
    public string promptMessage;
    //this function will be called from our player.
    private int value = 20;

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
        promptMessage = "Dostajesz " + value + " HP (E)";
    }
    public void BaseInteract()
    {
        Interact();
    }
    protected virtual void Interact()
    {
        //we wont have any code written in this function
        //this is a template function to be overridden by our subclasses
    }
    protected virtual void Interact1()
    {
        //we wont have any code written in this function
        //this is a template function to be overridden by our subclasses
    }
}