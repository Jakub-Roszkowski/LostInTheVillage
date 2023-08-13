using UnityEngine;

public class WineInteract : AbstractInteractableObject
{
    [SerializeField]
    private AudioSource eatingSound;

    public bool iseat = true;
    private string promptMessageTemp;
    protected override void Interact()
    {
        promptMessageTemp = Helpers.Languages.SetTextWineInteract();
    }
    protected override void Interact2()
    {
        drunk playerdrunk = GameObject.FindWithTag("MainCamera").GetComponent<drunk>();

        if (playerdrunk != null && iseat)
        {
            playerdrunk.DrunkEffect();
            eatingSound.Play();
            iseat = false;

            Destroy(gameObject, 1);
        }
    }

    protected override string promptMessage()
    {
        return promptMessageTemp;
    }
}
