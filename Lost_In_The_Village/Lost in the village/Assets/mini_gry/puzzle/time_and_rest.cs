using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class time_and_rest : MonoBehaviour
{
    public TMP_Text Time_TMP;
    public TMP_Text Time_TMP2;
    System.DateTime time;
    public static System.DateTime timestart;
    private static string timeres = "";
    public static int counter;
    public static int soundInt;



    public AudioSource BGM;
    public AudioClip correct;
    public AudioClip notcorrect;
    public AudioClip win;

    public GameObject PanelWIN;

    public static bool ifsound;

    void Start()
    {
        counter = 0;
        ifsound = false;
        counter = 0;
        timeres = "";
        timestart = DateTime.Now;
        PanelWIN.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timeres = (DateTime.Now - timestart).Minutes.ToString() + ":" + (DateTime.Now - timestart).Seconds.ToString();
        Time_TMP.text = timeres;

        if (ifsound)
        {
            if (counter == 16)
            {
                soundInt = 2;
                PanelWIN.SetActive(true);
                timeres = (DateTime.Now - timestart).Minutes.ToString() + ":" + (DateTime.Now - timestart).Seconds.ToString();
                Time_TMP2.text ="wygra³eœ w czasie:\n"+ timeres+"\n"+"Naciœnij F8 aby zacz¹æ ponownie";
                counter = 17;
            }
                sound();
            ifsound = false;
        }

        Restart_game();
        Finish_game();

    }

    public void ChangeBGM(AudioClip music)
    {
        //if (BGM.clip.name == music.name)
        //    return;

        Debug.Log(music.name);
        BGM.Stop();
        BGM.clip = music;
        BGM.Play();
    }

    public void sound()
    {
        if (soundInt == 0)
        {
            ChangeBGM(correct);

        }
        else if (soundInt == 1)
        {
            ChangeBGM(notcorrect);
        }
        else
            ChangeBGM(win);
    }

    public static void changemusic(int sound)
    {
        soundInt = sound;
        ifsound = true;

    }



    public void Restart_game()
    {
        if (Input.GetKeyDown(KeyCode.F8) || Input.GetKeyDown(KeyCode.Joystick1Button0))
        {
            Time.timeScale = 1f;
            Retry();
        }
    }

    public void Retry()
    {
        //Restarts current level
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Finish_game()
    {
        if (Input.GetKeyDown(KeyCode.F9))
        {
            Time.timeScale = 1f;
            Finish();
        }
    }

    public void Finish()
    {

        foreach (GameObject obj in MoveDontDestroyOnLoadObjects.dontDestroyObjects)
        {
            // Wy³¹cz sam obiekt
            obj.SetActive(true);
        }




        SceneManager.LoadScene("empty");
    }
}
