using LostInTheVillage.Character;
using LostInTheVillage.Helpers;
using LostInTheVillage.Interactable.Interface;
using TMPro;
using UnityEngine;

namespace LostInTheVillage.Interactable
{
    public class Plotka : AbstractInteractableObject
    {
        [SerializeField] private GameObject objToActive;
        [SerializeField] private TextMeshProUGUI destinationText;
        [SerializeField] private CharacterMessage roszkolCharacter;

        public static bool IsToFeed { get; set; }

        private string promptMessageTemp;

        private void Start()
        {
            IsToFeed = false;
        }

        protected override void Interact()
        {
            promptMessageTemp = IsToFeed ? Languages.SetTextFeed() : "";
        }

        protected override void Interact2()
        {
            if (IsToFeed)
            {
                objToActive.SetActive(true);
                gameObject.SetActive(false);
                roszkolCharacter.Place = PlaceEnum.Roszkol2;
                setDestinationText();
            }
        }

        private void setDestinationText()
        {
            destinationText.text = Languages.SetTextFindRoszkol();
        }

        protected override string PromptMessage()
        {
            return promptMessageTemp;
        }
    }
}
