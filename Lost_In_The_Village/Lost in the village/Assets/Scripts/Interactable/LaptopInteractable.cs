using LostInTheVillage.Character;
using LostInTheVillage.Helpers;
using LostInTheVillage.Interactable.Interface;
using TMPro;
using UnityEngine;

namespace LostInTheVillage.Interactable
{
    public class LaptopInteractable : AbstractInteractableObject
    {
        [SerializeField] private GameObject[] objectsToDeactivate;
        [SerializeField] private CharacterMessage eagleCharacter;
        [SerializeField] private TextMeshProUGUI destinationText;

        public static bool IsToSee { get; set; } = false;

        private string promptMessageTemp;


        private void Start()
        {
            IsToSee = false;
        }
        private void DisableObjects()
        {
            foreach (var obj in objectsToDeactivate)
            {
                if (obj != null)
                {
                    obj.SetActive(false);
                }
            }
        }

        protected override void Interact()
        {
            string text = Languages.SetTextLaptopInteract();
            string notAvailableText = Languages.SetTextNotAvailable();

            promptMessageTemp = IsToSee ? text : notAvailableText;
        }

        protected override void Interact2()
        {
            if (IsToSee)
            {
                DisableObjects();
                eagleCharacter.Place = PlaceEnum.OrzelLaptop;
                SetText();
                DoorEvacuation.IsToSee = true;
                IsToSee = false;
            }
        }

        private void SetText()
        {
            destinationText.text = LostInTheVillage.Helpers.Languages.SetTextEagle();
        }

        protected override string PromptMessage()
        {
            return promptMessageTemp;
        }
    }
}
