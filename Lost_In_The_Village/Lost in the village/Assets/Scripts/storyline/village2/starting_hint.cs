using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class starting_hint : MonoBehaviour
{
    public Canvas canvasToActivate;
    private InputManagerToExitCanva inputManager;

    public AudioSource BGM;
    public AudioClip wiadomosc;

    public string text;

    public TextMeshProUGUI promptText;


    private void Start()
    {
        BGM.Stop();
        inputManager = GetComponent<InputManagerToExitCanva>();
    }

    private void Update()
    {
        if (inputManager.onFoot.Exit.triggered)
        {
            canvasToActivate.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            ChangeBGM(wiadomosc);
            canvasToActivate.gameObject.SetActive(true);
            promptText.text = text;

        }
    }

    public void ChangeBGM(AudioClip music)
    {



        BGM.Stop();
        BGM.clip = music;
        BGM.Play();

    }


}



