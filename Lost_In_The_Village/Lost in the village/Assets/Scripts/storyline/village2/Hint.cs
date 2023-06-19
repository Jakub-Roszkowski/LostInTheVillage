using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Hint : MonoBehaviour
{
    public Canvas canvasToActivate;
    private InputManagerToExitCanva inputManager;

    public AudioSource BGM;
    public AudioClip wiadomosc;
    public TextMeshProUGUI promptText;

    public bool ifistoOpen = false;

    public string text;

    public TextMeshProUGUI promptText2;

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
            if (ifistoOpen)
            {
                ChangeBGM(wiadomosc);
                canvasToActivate.gameObject.SetActive(true);
                promptText2.text = text;

            }
            else
            {
                DisplayPromptText();
            }
        }
    }

    public void ChangeBGM(AudioClip music)
    {



        BGM.Stop();
        BGM.clip = music;
        BGM.Play();

    }

    private void DisplayPromptText()
    {
        promptText.text = "Nie posiadasz klucza";

        StartCoroutine(ClearPromptText(3f));
    }

    private System.Collections.IEnumerator ClearPromptText(float delay)
    {
        yield return new WaitForSeconds(delay);

        promptText.text = string.Empty;
    }
}



