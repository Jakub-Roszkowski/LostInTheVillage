using LostInTheVillage.Helpers.Translations;
using LostInTheVillage.Interactable.Interface;
using UnityEngine;

namespace LostInTheVillage.Interactable
{
    public class WineInteract : AbstractInteractableObject
    {
        [SerializeField] private AudioSource eatingSound;

        private bool isToDrink = true;
        private string promptMessageTemp;
        protected override void Interact()
        {
            promptMessageTemp = LanguagesTranslation.SetTextWineInteract();
        }
        protected override void Interact2()
        {
            Drunk playerdrunk = GameObject.FindWithTag("MainCamera").GetComponent<Drunk>();

            if (playerdrunk != null && isToDrink)
            {
                playerdrunk.DrunkEffect();
                eatingSound.Play();
                isToDrink = false;

                Destroy(gameObject, 1);
            }
        }

        protected override string PromptMessage()
        {
            return promptMessageTemp;
        }
    }
}
