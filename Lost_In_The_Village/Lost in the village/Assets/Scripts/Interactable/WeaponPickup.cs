using LostInTheVillage.Helpers.Translations;
using LostInTheVillage.Player;
using UnityEngine;

namespace LostInTheVillage.Interactable
{
    public class WeaponPickup : MonoBehaviour
    {
        [SerializeField] private GunManager gunManager;

        public string PromptMessage { get; private set; }

        private bool isToSee = false;

        public void Interact(GameObject wepaon)
        {
            string pickupText = LanguagesTranslation.SetTextPickUp();

            if (!gunManager.IsTheSame(wepaon))
            {
                PromptMessage = pickupText;
                isToSee = true;
            }
            else
            {
                PromptMessage = "";
                isToSee = false;
            }
        }

        public void Interact2(GameObject weapon)
        {
            if (isToSee)
            {
                gunManager.PickupWeapon(weapon.tag);
                weapon.SetActive(false);
            }
        }
    }
}
