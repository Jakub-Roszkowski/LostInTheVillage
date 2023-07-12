using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mini_game_menu : MonoBehaviour
{
    public GameObject gamesPanel;

    public GameObject[] objects_to_disactive;
    private PlayerInput playerInput;
    public PlayerInput.OnFootActions onFoot;
    public bool ingame = false;
    public static bool ingame2 = false;
    void Awake()
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







    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (onFoot.Exit.triggered)
        {
            Quit();
        }
        if (ingame)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            //Time.timeScale = 0f;
        }
        if (ingame2)
        {
            Time.timeScale = 0f;
        }
    }


    public void Quit()
    {
        ingame = false;
        ingame2 = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1f;
        gamesPanel.SetActive(false);
        foreach (GameObject elem in objects_to_disactive)
        {
            elem.SetActive(true);
        }
    }

    public void milioneirs()
    {
        ingame = true;
        ingame2 = false;
        SceneManager.LoadScene("milioneirs");
        Time.timeScale = 1f;
    }

    public void puzzle()
    {
        ingame = true;
        ingame2 = false;
        SceneManager.LoadScene("puzzle");
        Time.timeScale = 1f;

    }

    public void superPlatform()
    {
        ingame = true;
        ingame2 = false;
        SceneManager.LoadScene("SuperPlatform");
        Time.timeScale = 1f;
    }

}
