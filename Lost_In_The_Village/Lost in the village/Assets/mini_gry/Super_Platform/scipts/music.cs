using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class music : MonoBehaviour
{
    // Start is called before the first frame update

    public TMP_Text Mute_TMP;
    public AudioSource BGM;
    public GameObject muteSounds_button;

    private bool mute = false;


    private AudioSource audioSource;
    private float glosnosc;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        glosnosc = audioSource.volume;
    }

    // Update is called once per frame
    void Update()
    {
        //if (mute) Mute_TMP.text = "0";
        //else Mute_TMP.text = "1";

        //muteSounds_button.transform.GetComponent<Button>().onClick.AddListener(onClickButton);
        //if (Input.GetKeyDown(KeyCode.Joystick1Button5)) onClickButton();
        if (Pause.MusicisMute)
        {
            audioSource.volume = 0f;
        }
        else
        {
            audioSource.volume = glosnosc;
        }
    }



    private void onClickButton()
    {
        if (!mute)
        {
            BGM.volume = 0f;
            mute = true;
        }

        else
        {
            BGM.volume = 0.2f;
            mute = false;
        }
    }
}
