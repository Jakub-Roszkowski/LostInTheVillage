using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public enum Level
{
    Easy,
    Medium,
    Hard
}

public class Pause : MonoBehaviour
{

    private InputManagerToMenu inputManager;

    public static bool GameIsPaused = false;
    public static bool MusicisMute = false;
    public static bool SoundisMute = false;
    public static Level currentLevel = Level.Medium;

    public GameObject pauseMenu;
    public RawImage image;

    void Start()
    {
        inputManager = GetComponent<InputManagerToMenu>();
    }

    // Update is called once per frame
    void Update()
    {
        if (inputManager.onFoot.Pause.triggered)
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
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;


        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Resume()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

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
        SceneManager.LoadScene("Village1");
    }
    public void MuteMusic()
    {
        MusicisMute = !MusicisMute;
    }
    public void MuteSound()
    {
        SoundisMute = !SoundisMute;
    }

    public void SetEasy()
    {
        currentLevel = Level.Easy;
        image.color = Color.green;
    }

    public void SetMedium()
    {
        currentLevel = Level.Medium;
        image.color = Color.yellow;
    }
    public void SetHard()
    {
        currentLevel = Level.Hard;
        image.color = Color.red;
    }
}

