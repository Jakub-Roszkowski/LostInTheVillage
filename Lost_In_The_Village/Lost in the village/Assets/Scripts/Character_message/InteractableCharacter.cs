using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableCharacter : MonoBehaviour
{

    public string promptMessage;
    private string text;
    private string text2;
    public bool to_see = false;
    public bool to_see2 = true;

    private CharacterMessage characterMessage;

    public InteractableCharacter next_character;

    void Start()
    {
        characterMessage = GetComponent<CharacterMessage>();
        to_see = false;
        to_see2 = true;
    }

    private void Update()
    {

    }
    public void Interact()
    {

        switch (Language.language)
        {
            case Language_enum.Polish:
                text = "Rozmawiaj (E)";
                break;
            case Language_enum.English:
                text = "Talk (E)";
                break;
            case Language_enum.German:
                text = "Reden (E)";
                break;
            case Language_enum.Spain:
                text = "Hablar (E)";
                break;
        }


        switch (Language.language)
        {
            case Language_enum.Polish:
                text2 = "Rozmowa niedostêpna";
                break;
            case Language_enum.English:
                text2 = "Conversation unavailable";
                break;
            case Language_enum.German:
                text2 = "Konversation nicht verfügbar";
                break;
            case Language_enum.Spain:
                text2 = "Conversación no disponible";
                break;
        }


        if (to_see)
            promptMessage = text;
        else
            promptMessage = text2;
    }
    public void Interact2()
    {
        if (to_see && to_see2)
        {
            if (characterMessage.place == Place_enum.Welcome_Village2 || characterMessage.place == Place_enum.Bar2 || characterMessage.place == Place_enum.Roszkol2)
            {
                next_character.to_see = true;
            }
            else if (characterMessage.place == Place_enum.Roszkol1)
            {
                Plotka.toFeed = true;
            }
            else if (characterMessage.place == Place_enum.Orzel_welcome)
            {
                Glasses.toSee = true;
            }
            else if (characterMessage.place == Place_enum.Orzel_glasses)
            {
                InteractableBackup.toSee = true;
            }
            else if (characterMessage.place == Place_enum.Orzel_tunel)
            {
                InteractableLaptop.toSee = true;
            }
            else if (characterMessage.place == Place_enum.Orzel_laptop)
            {
                DoorEvacuation.toSee = true;
            }
            else if (characterMessage.place == Place_enum.Village1Man)
            {
                LoadSceneOnTrigger.ifistoOpen = true;
            }


            if (characterMessage != null)
            {
                characterMessage.Message();
                StartCoroutine(set_promttext(characterMessage.audio.length));
            }
        }
    }

    IEnumerator set_promttext(float time1)
    {
        to_see2 = false;
        yield return new WaitForSeconds(time1 + 2.0f);
        to_see2 = true;
    }

}
