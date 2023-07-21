using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Control : MonoBehaviour
{
    public Canvas canvasToActivate;
    private InputManagerToExitCanva inputManager;

    public AudioSource BGM;
    public AudioClip wiadomosc;

    public string promptMessage;
    private string text;


    public TextMeshProUGUI textCanva;

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


    public void Interact()
    {

        switch (Language.language)
        {
            case Language_enum.Polish:
                text = "Sterowanie (E)";
                break;
            case Language_enum.English:
                text = "Control (E)";
                break;
            case Language_enum.German:
                text = "Kontrolle (E)";
                break;
            case Language_enum.Spain:
                text = "Mando (E)";
                break;
        }
        promptMessage = text;
    }

    public void Interact2()
    {
        canvasToActivate.gameObject.SetActive(true);
        SetText();
    }


    private void SetText()
    {
        switch (Language.language)
        {
            case Language_enum.Polish:
                textCanva.text = "Sterowanie:" + "\n" +
                    "WSAD - poruszanie siê " + "\n" +
                    "spacja - skok" + "\n" +
                    "E - interakcja" + "\n" +
                    "Shift - sprint" + "\n" +
                    "R - prze³adowanie" + "\n" +
                    "esc - pauza" + "\n" +
                    "F - latarka" + "\n" +
                    "1, 2, 3, 4 - wybór broni" + "\n" +
                    "Q - zamkniecie wiadomosci" + "\n" +
                    "";
                break;
            case Language_enum.English:
                textCanva.text = "Controls:" + "\n" +
                     "WSAD - moving " + "\n" +
                     "space - jump" + "\n" +
                     "E - interaction" + "\n" +
                     "Shift - sprint" + "\n" +
                     "R - reload" + "\n" +
                     "esc - pause" + "\n" +
                     "F - flashlight" + "\n" +
                     "1, 2, 3, 4 - weapon selection" + "\n" +
                     "Q - close message" + "\n" +
                     "";
                break;
            case Language_enum.German:
                textCanva.text = "Kontrolle:" + "\n“" +
                     "WSAD – Verschieben" + "\n" +
                     "Leertaste – Sprung" + "\n" +
                     "E – Interaktion" + "\n" +
                     "Shift – Sprint" + "\n“" +
                     "R – neu laden" + "\n" +
                     "esc – Pause" + "\n" +
                     "F – Taschenlampe" + "\n" +
                     "1, 2, 3, 4 – Waffenauswahl" + "\n" +
                     "Q – Nachricht schließen" + "\n" +
                     "";
                break;
            case Language_enum.Spain:
                textCanva.text = "Controles:" + "\n" +
                     "WSAD - moviendo" + "\n" +
                     "espacio - saltar" + "\n" +
                     "E - interacción" + "\n" +
                     "Shift - sprint" + "\n" +
                     "R - recargar" + "\n" +
                     "esc - pausa" + "\n" +
                     "F - linterna" + "\n" +
                     "1, 2, 3, 4 - selección de armas" + "\n" +
                     "Q - cerrar mensaje" + "\n" +
                     "";
                break;
        }
    }


    public void ChangeBGM(AudioClip music)
    {



        BGM.Stop();
        BGM.clip = music;
        BGM.Play();

    }
}



