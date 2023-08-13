using UnityEngine;

public class GameConsoleInteract : AbstractInteractableObject
{
    [SerializeField] private GameObject gamesPanel;
    [SerializeField] private GameObject[] objects_to_disactive;

    private string promptMessageTemp;

    protected override void Interact()
    {
        promptMessageTemp = Helpers.Languages.SetTextConsoleInteract();
    }

    protected override void Interact2()
    {
        drunk playerdrunk = GameObject.FindWithTag("MainCamera").GetComponent<drunk>();

        if (playerdrunk != null)
        {
            playerdrunk.DisableDrunkEffect();
        }

        Time.timeScale = 0f;
        gamesPanel.SetActive(true);

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

        foreach (GameObject elem in objects_to_disactive)
        {
            elem.SetActive(false);
        }
    }

    protected override string promptMessage()
    {
        return promptMessageTemp;
    }
}
