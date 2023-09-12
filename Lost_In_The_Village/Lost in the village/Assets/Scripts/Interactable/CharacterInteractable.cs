using LostInTheVillage.Character;
using LostInTheVillage.Helpers.Translations;
using LostInTheVillage.Interactable.Interface;
using LostInTheVillage.Interactable.StartPuzzle;
using LostInTheVillage.Storyline.Village1;
using System.Collections;
using UnityEngine;

namespace LostInTheVillage.Interactable
{
    public class CharacterInteractable : AbstractInteractableObject
    {
        [SerializeField] private CharacterInteractable nextCharacter;

        private CharacterMessage characterMessage;

        public bool ToSee { get; set; } = false;

        private bool toSee2 = true;
        private string promptMessageTemp;
        private string text;
        private string text2;

        private void Start()
        {
            characterMessage = GetComponent<CharacterMessage>();
            ToSee = false;
            toSee2 = true;
        }
        protected override void Interact()
        {
            text = LanguagesTranslation.SetTextCharacterInteract();
            text2 = LanguagesTranslation.SetTextCharacterInteract2();

            promptMessageTemp = ToSee ? text : text2;
        }
        protected override void Interact2()
        {
            if (ToSee && toSee2)
            {
                HandleCharacterInteraction();
            }
        }
        private void HandleCharacterInteraction()
        {
            if (characterMessage == null)
            {
                return;
            }

            switch (characterMessage.Place)
            {
                case PlaceEnum.Welcome_Village2:
                case PlaceEnum.Bar2:
                case PlaceEnum.Roszkol2:
                    nextCharacter.ToSee = true;
                    break;
                case PlaceEnum.Roszkol1:
                    Plotka.IsToFeed = true;
                    break;
                case PlaceEnum.OrzelWelcome:
                    Glasses.IsToSee = true;
                    break;
                case PlaceEnum.OrzelGlasses:
                    InteractableBackup.ToSee = true;
                    break;
                case PlaceEnum.OrzelTunel:
                    LaptopInteractable.IsToSee = true;
                    break;
                case PlaceEnum.OrzelLaptop:
                    DoorEvacuation.IsToSee = true;
                    break;
                case PlaceEnum.Village1Man:
                    LoadSceneOnTrigger.IfIsToOpen = true;
                    break;
            }

            characterMessage.Message();
            StartCoroutine(SetPromptText(characterMessage.GetComponent<AudioSource>().clip.length));
        }

        private IEnumerator SetPromptText(float time1)
        {
            toSee2 = false;
            yield return new WaitForSeconds(time1 + 2.0f);
            toSee2 = true;
        }

        protected override string PromptMessage()
        {
            return promptMessageTemp;
        }
    }
}
