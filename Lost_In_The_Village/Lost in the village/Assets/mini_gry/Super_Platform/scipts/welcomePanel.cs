using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class welcomePanel : MonoBehaviour
{
    public GameObject PanelNick;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Return) || Input.GetKeyDown(KeyCode.Joystick1Button2))
        {
            PanelNick.SetActive(false);
            PlayerPlatform.start = true;
            PlayerPlatform.start_movement = true;

            PlayerPlatform.timestart = DateTime.Now;


        }
    }
}
