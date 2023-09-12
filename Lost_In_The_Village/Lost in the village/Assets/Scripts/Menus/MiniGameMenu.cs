using LostInTheVillage.Helpers;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace LostInTheVillage.Menus
{
    public class MiniGameMenu : MonoBehaviour
    {
        [SerializeField] private GameObject gamesPanel;
        [SerializeField] private GameObject[] objectsToActive;

        public static bool IsInGame2 { get; set; } = false;

        private PlayerInput.OnFootActions onFoot;
        private bool IsInGame = false;
        private PlayerInput playerInput;

        private void Awake()
        {
            playerInput = new PlayerInput();
            onFoot = playerInput.OnFoot;
        }

        private void OnEnable()
        {
            onFoot.Enable();
        }

        private void OnDisable()
        {
            onFoot.Disable();
        }

        private void Start()
        {
            IsInGame = false;
        }

        private void Update()
        {
            if (onFoot.Exit.triggered)
            {
                Quit();
            }
            if (IsInGame)
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
            if (IsInGame2)
            {
                Time.timeScale = 0f;
            }
        }

        public void Quit()
        {
            IsInGame = false;
            IsInGame2 = false;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            Time.timeScale = 1f;
            gamesPanel.SetActive(false);
            foreach (GameObject elem in objectsToActive)
            {
                elem.SetActive(true);
            }
        }

        public void Milioneirs()
        {
            StartGame(Scenes.Milioneirs);
        }

        public void Puzzle()
        {
            StartGame(Scenes.Puzzle);
        }

        public void SuperPlatform()
        {
            StartGame(Scenes.SuperPlatform);
        }

        public void StartGame(string sceneName)
        {
            IsInGame = true;
            IsInGame2 = false;
            SceneManager.LoadScene(sceneName);
            Time.timeScale = 1f;
        }
    }
}