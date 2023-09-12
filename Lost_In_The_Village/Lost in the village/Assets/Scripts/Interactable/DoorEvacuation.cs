using LostInTheVillage.Helpers.Translations;
using LostInTheVillage.Interactable.Interface;
using UnityEngine;

namespace LostInTheVillage.Interactable
{
    public class DoorEvacuation : AbstractInteractableObject
    {
        [SerializeField] private GameObject objectToActivate;
        [SerializeField] private GameObject[] objectsToDeactivate;

        public static bool IsToSee { get; set; } = false;

        private string promptMessageTemp;

        private void Start()
        {
            IsToSee = false;
        }

        protected override void Interact()
        {
            string text1 = LanguagesTranslation.SetTextDoorEvacuationInteract();
            string text2 = LanguagesTranslation.SetTextDoorEvacuationInteract2();

            promptMessageTemp = IsToSee ? text1 : text2;
        }

        protected override void Interact2()
        {
            if (IsToSee)
            {
                ActivateObjects();
            }
        }

        private void ActivateObjects()
        {
            if (objectToActivate != null)
            {
                objectToActivate.SetActive(true);
            }

            foreach (var obj in objectsToDeactivate)
            {
                if (obj != null)
                {
                    obj.SetActive(false);
                }
            }
        }

        protected override string PromptMessage()
        {
            return promptMessageTemp;
        }
    }
}
