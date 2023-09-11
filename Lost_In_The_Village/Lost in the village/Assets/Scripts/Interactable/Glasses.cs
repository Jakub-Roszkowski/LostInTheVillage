using LostInTheVillage.Character;
using LostInTheVillage.Helpers;
using LostInTheVillage.Interactable.Interface;
using TMPro;
using UnityEngine;

namespace LostInTheVillage.Interactable
{
    public class Glasses : AbstractInteractableObject
    {
        [SerializeField] private CharacterMessage eagleCharacter;
        [SerializeField] private TextMeshProUGUI destinationText;

        public static bool IsToSee { get; set; } = false;

        private string promptMessageTemp;
        private string text;

        private void Start()
        {
            IsToSee = false;
        }

        protected override void Interact()
        {
            string text = Languages.SetTextPickUp();

            promptMessageTemp = IsToSee ? text : "";
        }

        protected override void Interact2()
        {
            if (IsToSee)
            {
                gameObject.SetActive(false);
                eagleCharacter.Place = PlaceEnum.OrzelGlasses;
                SetDestinationText();
            }
        }
        private void SetDestinationText()
        {
            destinationText.text = Languages.SetTextEagle();
        }

        protected override string PromptMessage()
        {
            return promptMessageTemp;
        }
    }
}
