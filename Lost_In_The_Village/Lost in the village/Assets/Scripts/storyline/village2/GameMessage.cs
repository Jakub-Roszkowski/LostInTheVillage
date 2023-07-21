using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameMessage : MonoBehaviour
{
    public Canvas canvasToActivate;

    public AudioSource BGM;
    public AudioClip wiadomosc;


    public TextMeshProUGUI promptText;
    public TextMeshProUGUI textInMessage;
    private bool visited = false;




    private PlayerInput playerInput;
    public PlayerInput.OnFootActions onFoot;
    void Awake()
    {
        playerInput = new PlayerInput();
        onFoot = playerInput.OnFoot;

    }


    private void OnEnable()
    {
        onFoot.Enable();
    }


    private void OnDisable()
    {
        onFoot.Disable();
    }



    private void Start()
    {
        BGM.Stop();
    }

    private void Update()
    {
        if (onFoot.Exit.triggered)
        {
            canvasToActivate.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!visited)
        {
            if (other.CompareTag("Player"))
            {

                ChangeBGM(wiadomosc);
                canvasToActivate.gameObject.SetActive(true);
                setText();
                setTextInMessage();

                visited = true;

            }
        }
    }

    public void ChangeBGM(AudioClip music)
    {
        BGM.Stop();
        BGM.clip = music;
        BGM.Play();
    }

    private void setText()
    {

        switch (Language.language)
        {
            case Language_enum.Polish:
                promptText.text = "PodejdŸ do komputera";
                break;
            case Language_enum.English:
                promptText.text = "Go to the computer";
                break;
            case Language_enum.German:
                promptText.text = "Gehen Sie zum Computer";
                break;
            case Language_enum.Spain:
                promptText.text = "Ir a la computadora";
                break;
        }
    }
    private void setTextInMessage()
    {

        switch (Language.language)
        {
            case Language_enum.Polish:
                textInMessage.text = "Roszkol postanowi³ zabezpieczyæ wejœcie do swojego domu prost¹ gr¹ któr¹ uruchomisz na komputerze przy wejœciu.";
                break;
            case Language_enum.English:
                promptText.text = "Roszkol decided to secure the entrance to his house with a simple game that you will run on the computer at the entrance.";
                break;
            case Language_enum.German:
                promptText.text = "Roszkol beschloss, den Eingang zu seinem Haus mit einem einfachen Spiel zu sichern, das Sie am Eingang auf dem Computer ausführen.";
                break;
            case Language_enum.Spain:
                promptText.text = "Roszkol decidió asegurar la entrada a su casa con un juego simple que ejecutará en la computadora en la entrada.";
                break;
        }
    }
}



