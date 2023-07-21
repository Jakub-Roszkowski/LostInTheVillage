using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WeaponPickup : MonoBehaviour
{
    public GunManager gunManager;
    public string promptMessage;
    private string text;
    private bool isToSee = false;


    public void Interact(GameObject wepaon)
    {

        switch (Language.language)
        {
            case Language_enum.Polish:
                text = "Podnieœ " + wepaon.tag + " (E)";
                break;
            case Language_enum.English:
                text = "Pick up " + wepaon.tag + " (E)";
                break;
            case Language_enum.German:
                text = "Abholen " + wepaon.tag + " (E)";
                break;
            case Language_enum.Spain:
                text = "Levantar " + wepaon.tag + " (E)";
                break;
        }
        if (!gunManager.IsTheSame(wepaon))
        {
            promptMessage = text;
            isToSee = true;
        }
        else
        {
            promptMessage = "";
            isToSee = false;
        }

    }

    public void Interact2(GameObject weapon)
    {
        if (isToSee)
        {
            gunManager.PickupWeapon(weapon.tag);
            gunManager.DropWeapon(weapon.tag);
            weapon.SetActive(false);
        }
    }

}
