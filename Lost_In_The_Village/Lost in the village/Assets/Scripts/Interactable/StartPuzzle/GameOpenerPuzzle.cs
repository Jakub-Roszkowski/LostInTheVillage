using LostInTheVillage.Character;
using LostInTheVillage.Helpers.Translations;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace LostInTheVillage.Interactable.StartPuzzle
{
    public class GameOpenerPuzzle : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI destinationText;
        [SerializeField] private CharacterMessage eagleCharacter;
        [SerializeField] private GameObject bossObjects;

        public static bool IsInGame { get; set; } = false;
        public static bool HasFinishedGame { get; set; } = false;

        private void Start()
        {
            IsInGame = false;
            HasFinishedGame = false;
        }

        private void Update()
        {
            if (HasFinishedGame)
            {
                eagleCharacter.Place = PlaceEnum.OrzelTunel;
                SetDestinationText();
                bossObjects.SetActive(true);
                Time.timeScale = 1f;
                HasFinishedGame = false;
                LaptopInteractable.IsToSee = true;
            }
        }

        public void StartGame()
        {
            IsInGame = true;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene(Helpers.Scenes.Puzzle);
        }

        private void SetDestinationText()
        {
            destinationText.text = LanguagesTranslation.SetTextEagle();
        }
    }
}
