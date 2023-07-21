using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameConsoleInteract : Interactable_game_console
{
    public GameObject gamesPanel;
    public GameObject[] objects_to_disactive;
    protected override void Interact()
    {
        drunk playerdrunk = GameObject.FindWithTag("MainCamera").GetComponent<drunk>();


        if (playerdrunk != null)
        {

            playerdrunk.DisableDrunkEffect();
        }



        Time.timeScale = 0f;
        gamesPanel.SetActive(true);


        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

        foreach (GameObject elem in objects_to_disactive)
        {
            elem.SetActive(false);
        }
    }
}
