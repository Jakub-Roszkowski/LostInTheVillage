using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace LostInTheVillage.Interactable.StartSuperPlatform
{
    public class GameOpenerSuperPlatform : MonoBehaviour
    {
        [SerializeField] private GameObject objToDestroy;
        [SerializeField] private TextMeshProUGUI promptText;

        public static bool IsInGame { get; set; } = false;
        public static bool HasFinishedGame { get; set; } = false;

        private InteractableGameToIN interactableGameToIN;

        private void Start()
        {
            interactableGameToIN = GetComponent<InteractableGameToIN>();
            IsInGame = false;
            HasFinishedGame = false;
        }

        private void Update()
        {
            if (HasFinishedGame)
            {
                RemoveObj();
                SetText();
                HasFinishedGame = false;
            }
        }
        public void StartGame()
        {
            IsInGame = true;
            SceneManager.LoadScene(LostInTheVillage.Helpers.Scenes.SuperPlatform);
        }
        private void RemoveObj()
        {
            if (objToDestroy != null)
            {
                Destroy(objToDestroy);
            }
            interactableGameToIN.ToSee = false;
        }

        private void SetText()
        {
            promptText.text = LostInTheVillage.Helpers.Languages.SetTextFindRoszkol();
        }
    }
}
