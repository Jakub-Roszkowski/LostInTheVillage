using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_console_interact : Interactable_game_console
{
    public GameObject gamesPanel;
    public GameObject[] objects_to_disactive;
    protected override void Interact()
    {
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
