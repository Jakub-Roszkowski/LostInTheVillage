using LostInTheVillage.Helpers.Translations;
using LostInTheVillage.Interactable.StartPuzzle;
using LostInTheVillage.Menus;
using LostInTheVillage.MiniGames.RemoveDontDestroy;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace LostInTheVillage.MiniGames.Games.Puzzle.Scripts
{
    public class PuzzleTimerController : MonoBehaviour
    {
        [SerializeField] private TMP_Text Time_TMP;
        [SerializeField] private TMP_Text Time_TMP2;

        [SerializeField] private AudioSource BGM;
        [SerializeField] private AudioClip correct;
        [SerializeField] private AudioClip notcorrect;
        [SerializeField] private AudioClip win;

        [SerializeField] private GameObject PanelWIN;

        public static int Counter { get; set; }

        private static bool ifsound;
        private static int soundState;

        private DateTime startTime;
        private string timeres = "";
        private void Start()
        {
            Counter = 0;
            soundState = 0;
            timeres = "";
            startTime = DateTime.Now;
            PanelWIN.SetActive(false);
        }

        private void Update()
        {
            timeres = (DateTime.Now - startTime).ToString("mm':'ss");
            Time_TMP.text = timeres;

            if (ifsound)
            {
                if (Counter == 16)
                {
                    soundState = 2;
                    PanelWIN.SetActive(true);
                    Time_TMP2.text = LanguagesTranslation.SetTextPuzzle(timeres);

                    if (GameOpenerPuzzle.IsInGame)
                    {
                        GameOpenerPuzzle.HasFinishedGame = true;
                    }

                    Counter = 17;
                }
                PlaySound();
                ifsound = false;
            }
            RestartGame();
            FinishGame();
        }

        public static void ChangeMusic(int sound)
        {
            soundState = sound;
            ifsound = true;
        }

        private void ChangeBGM(AudioClip music)
        {
            Debug.Log(music.name);
            BGM.Stop();
            BGM.clip = music;
            BGM.Play();
        }

        private void PlaySound()
        {
            if (soundState == 0)
            {
                ChangeBGM(correct);
            }
            else if (soundState == 1)
            {
                ChangeBGM(notcorrect);
            }
            else
            {
                ChangeBGM(win);
            }
        }

        private void RestartGame()
        {
            if (Input.GetKeyDown(KeyCode.F8) || Input.GetKeyDown(KeyCode.Joystick1Button0))
            {
                Retry();
            }
        }

        private void Retry()
        {
            Time.timeScale = 1f;
            foreach (GameObject obj in MoveDontDestroyOnLoadObjects.dontDestroyObjects)
            {
                obj.SetActive(true);
            }
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        private void FinishGame()
        {
            if (Input.GetKeyDown(KeyCode.F9))
            {
                Time.timeScale = 1f;
                Finish();
            }
        }

        private void Finish()
        {
            Time.timeScale = 1f;
            foreach (GameObject obj in MoveDontDestroyOnLoadObjects.dontDestroyObjects)
            {
                obj.SetActive(true);
            }
            if (!GameOpenerPuzzle.IsInGame)
            {
                MiniGameMenu.IsInGame2 = true;
            }
            else
            {
                GameOpenerPuzzle.IsInGame = false;
            }
            SceneManager.LoadScene(Helpers.Scenes.Empty);
        }
    }
}

