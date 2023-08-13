using UnityEngine;

public class DonutInteract : AbstractInteractableObject
{
    [SerializeField] private AudioSource eatingSound;

    public bool iseat = true;

    private string promptMessageTemp;
    
    private static int value = 20;

    private void Update()
    {
        if (Pause.currentLevel == Level.Easy)
        {
            value = 30;
        }
        if (Pause.currentLevel == Level.Medium)
        {
            value = 20;
        }
        if (Pause.currentLevel == Level.Hard)
        {
            value = 5;
        }
    }

    protected override void Interact()
    {
        promptMessageTemp = Helpers.Languages.SetTextDonut() + " " + value + " HP (E)";
    }

    protected override void Interact2()
    {
        Health playerHealth = GameObject.FindWithTag("Player").GetComponent<Health>();

        if (playerHealth != null && iseat)
        {
            playerHealth.RestoreHealth(value);
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
