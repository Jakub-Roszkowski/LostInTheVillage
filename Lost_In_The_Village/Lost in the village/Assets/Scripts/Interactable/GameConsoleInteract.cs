using LostInTheVillage.Helpers.Translations;
using LostInTheVillage.Interactable.Interface;
using UnityEngine;

namespace LostInTheVillage.Interactable
{
    public class GameConsoleInteract : AbstractInteractableObject
    {
        [SerializeField] private GameObject gamesPanel;
        [SerializeField] private GameObject[] objectsToDeactivate;

        private string promptMessageTemp;

        protected override void Interact()
        {
            promptMessageTemp = LanguagesTranslation.SetTextConsoleInteract();
        }

        protected override void Interact2()
        {
            Drunk playerdrunk = GameObject.FindWithTag("MainCamera").GetComponent<Drunk>();

            if (playerdrunk != null)
            {
                playerdrunk.DisableDrunkEffect();
            }

            Time.timeScale = 0f;
            gamesPanel.SetActive(true);

            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

            foreach (GameObject elem in objectsToDeactivate)
            {
                elem.SetActive(false);
            }
        }

        protected override string PromptMessage()
        {
            return promptMessageTemp;
        }
    }
}
