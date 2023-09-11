using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace LostInTheVillage.Menus
{
    public enum Level
    {
        Easy,
        Medium,
        Hard
    }

    public class Pause : MonoBehaviour
    {
        [SerializeField] private GameObject pauseMenu;
        [SerializeField] private RawImage image;

        public static bool GameIsPaused { get; private set; } = false;
        public static bool MusicIsMute { get; private set; } = false;
        public static bool SoundIsMute { get; private set; } = false;
        public static Level CurrentLevel { get; private set; } = Level.Medium;

        private InputManagerToMenu inputManager;

        private void Start()
        {
            inputManager = GetComponent<InputManagerToMenu>();
            if (CurrentLevel == Level.Easy)
            {
                image.color = Color.green;
            }
            else if (CurrentLevel == Level.Medium)
            {
                image.color = Color.yellow;
            }
            else if (CurrentLevel == Level.Hard)
            {
                image.color = Color.red;
            }
        }

        private void Update()
        {
            if (inputManager.OnFoot.Pause.triggered)
            {
                if (GameIsPaused)
                {
                    Resume();
                }
                else
                {
                    Pause1();
                }
            }
        }

        public void Pause1()
        {
            UnityEngine.Cursor.visible = true;
            UnityEngine.Cursor.lockState = CursorLockMode.None;

            pauseMenu.SetActive(true);
            Time.timeScale = 0f;
            GameIsPaused = true;
        }

        public void Resume()
        {
            UnityEngine.Cursor.visible = false;
            UnityEngine.Cursor.lockState = CursorLockMode.Locked;

            pauseMenu.SetActive(false);
            Time.timeScale = 1f;
            GameIsPaused = false;
        }
        public void QuitGame()
        {
            Application.Quit();
        }

        public void Restart()
        {
            Resume();
            GameObject[] dontDestroyObjects = GameObject.FindGameObjectsWithTag("DontDestroyOnLoad");

            foreach (GameObject obj in dontDestroyObjects)
            {
                Destroy(obj);
            }

            SceneManager.LoadScene("Village1");
        }

        public void MuteMusic()
        {
            MusicIsMute = !MusicIsMute;
        }

        public void MuteSound()
        {
            SoundIsMute = !SoundIsMute;
        }

        public void SetEasy()
        {
            CurrentLevel = Level.Easy;
            image.color = Color.green;
        }

        public void SetMedium()
        {
            CurrentLevel = Level.Medium;
            image.color = Color.yellow;
        }
        public void SetHard()
        {
            CurrentLevel = Level.Hard;
            image.color = Color.red;
        }
    }
}