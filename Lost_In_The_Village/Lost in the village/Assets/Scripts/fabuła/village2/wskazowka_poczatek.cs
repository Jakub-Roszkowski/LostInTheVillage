using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class wskazowka_poczatek : MonoBehaviour
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
        if (inputManager.onFoot.Exit.triggered) // Sprawd�, czy zosta� naci�ni�ty przycisk wyj�cia (lub inny przycisk zdefiniowany w InputManagerze)
        {
            canvasToActivate.gameObject.SetActive(false); // Dezaktywuj Canvas
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Sprawd�, czy kolizja wyst�puje z graczem (lub innym obiektem o tagu "Player")
        {

                ChangeBGM(wiadomosc);
                canvasToActivate.gameObject.SetActive(true); // Aktywuj Canvas
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



