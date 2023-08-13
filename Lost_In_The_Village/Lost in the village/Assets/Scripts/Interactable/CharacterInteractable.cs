using System.Collections;
using UnityEngine;
public class CharacterInteractable : AbstractInteractableObject
{    
    [SerializeField] private CharacterInteractable next_character;

    private CharacterMessage characterMessage;

    public bool to_see = false;
    public bool to_see2 = true;

    private string promptMessageTemp;
    private string text;
    private string text2;

    void Start()
    {
        characterMessage = GetComponent<CharacterMessage>();
        to_see = false;
        to_see2 = true;
    }
    protected override void Interact()
    {
        text = Helpers.Languages.SetTextCharacterInteract();
        text2 = Helpers.Languages.SetTextCharacterInteract2();

        if (to_see)
            promptMessageTemp = text;
        else
            promptMessageTemp = text2;
    }
    protected override void Interact2()
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
                LaptopInteractable.toSee = true;
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
                StartCoroutine(set_promttext(characterMessage.GetComponent<AudioSource>().clip.length));
            }
        }
    }
    IEnumerator set_promttext(float time1)
    {
        to_see2 = false;
        yield return new WaitForSeconds(time1 + 2.0f);
        to_see2 = true;
    }

    protected override string promptMessage()
    {
        return promptMessageTemp;
    }
}
