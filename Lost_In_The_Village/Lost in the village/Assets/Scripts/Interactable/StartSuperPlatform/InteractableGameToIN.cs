using LostInTheVillage.Helpers;
using LostInTheVillage.Interactable.Interface;

namespace LostInTheVillage.Interactable.StartSuperPlatform
{
    public class InteractableGameToIN : AbstractInteractableObject
    {
        public bool ToSee { get; set; } = true;

        private GameOpenerSuperPlatform game_opener;
        private string text;
        private string promptMessageTemp;

        private void Start()
        {
            game_opener = GetComponent<GameOpenerSuperPlatform>();
            ToSee = true;
        }

        protected override void Interact()
        {
            text = Languages.SetTextGameToIn();

            if (ToSee)
                promptMessageTemp = text;
            else
                promptMessageTemp = "";
        }

        protected override void Interact2()
        {
            if (ToSee)
            {
                game_opener.StartGame();
            }
        }

        protected override string PromptMessage()
        {
            return promptMessageTemp;
        }
    }
}
