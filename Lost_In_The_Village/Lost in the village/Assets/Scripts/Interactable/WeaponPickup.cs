using UnityEngine;

public class WeaponPickup : MonoBehaviour
{
    [SerializeField] private GunManager gunManager;

    public string promptMessage;

    private string text;
    private bool isToSee = false;

    public void Interact(GameObject wepaon)
    {
        text = Helpers.Languages.SetTextPickUp();

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
