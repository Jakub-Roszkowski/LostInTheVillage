using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable_wine : MonoBehaviour
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
                promptMessage = "Napij siê wina (E)";
                break;
            case Language_enum.English:
                promptMessage = "Drink some wine (E)";
                break;
            case Language_enum.German:
                promptMessage = "Trink etwas Wein (E)";
                break;
            case Language_enum.Spain:
                promptMessage = "Toma un poco de vino (E)";
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
