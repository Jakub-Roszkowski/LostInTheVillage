using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable_Character : MonoBehaviour
{

    public string promptMessage;
    private string text;
    private string text2;
    public bool to_see = false;
    public bool to_see2 = true;

    private CharacterMessage characterMessage;

    public Interactable_Character next_character;

    void Start()
    {
        characterMessage = GetComponent<CharacterMessage>();
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
