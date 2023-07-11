using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class INPUT_NICK : MonoBehaviour
{


    public static string theName=" ";
    public TMP_InputField input;
    public GameObject PanelNick;
    public static bool start;



    void Start()
    {
        start=true;
    }



    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            theName = input.text;
            PanelNick.SetActive(false);

            QestionText.nick = theName;
            start = false;
            QestionText.timeif = true;

            QestionText.timestart = DateTime.Now;



        }
    }



}
