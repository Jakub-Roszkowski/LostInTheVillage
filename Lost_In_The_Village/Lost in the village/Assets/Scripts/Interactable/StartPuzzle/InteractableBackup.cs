using LostInTheVillage.Helpers.Translations;
using LostInTheVillage.Interactable.Interface;
using UnityEngine;

namespace LostInTheVillage.Interactable.StartPuzzle
{
    public class InteractableBackup : AbstractInteractableObject
    {
        [SerializeField] private string PromptMessageTemp;
        public static bool ToSee { get; set; } = false;

        private string text;
        private string text2;

        private GameOpenerPuzzle gameOpener;

        private void Start()
        {
            gameOpener = GetComponent<GameOpenerPuzzle>();
            ToSee = false;
        }

        protected override void Interact()
        {
            text = LanguagesTranslation.SetTextBackupInteract();
            text2 = LanguagesTranslation.SetTextNotAvailable();

            if (ToSee)
                PromptMessageTemp = text;
            else
                PromptMessageTemp = text2;
        }

        protected override void Interact2()
        {
            if (ToSee)
            {
                gameOpener.StartGame();
            }
        }

        protected override string PromptMessage()
        {
            return PromptMessageTemp;
        }
    }
}
