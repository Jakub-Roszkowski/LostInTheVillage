using LostInTheVillage.Character;
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

        public static bool InGame { get; set; } = false;
        public static bool HasFinishedGame { get; set; } = false;

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
            InGame = true;
            UnityEngine.Cursor.visible = true;
            UnityEngine.Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene(LostInTheVillage.Helpers.Scenes.Puzzle);
        }

        private void SetDestinationText()
        {
            destinationText.text = LostInTheVillage.Helpers.Languages.SetTextEagle();
        }
    }
}
