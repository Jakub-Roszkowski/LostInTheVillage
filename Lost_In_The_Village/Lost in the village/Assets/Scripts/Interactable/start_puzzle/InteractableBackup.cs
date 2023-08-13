public class InteractableBackup : AbstractInteractableObject
{
    public string promptMessageTemp;
    public static bool toSee = false;

    private string text;
    private string text2;

    private GameOpenerPuzzle game_opener;

    void Start()
    {
        game_opener = GetComponent<GameOpenerPuzzle>();
        toSee = false;
    }

    protected override void Interact()
    {
        text = Helpers.Languages.SetTextBackupInteract();
        text2 = Helpers.Languages.SetTextNotAvailable();

        if (toSee)
            promptMessageTemp = text;
        else
            promptMessageTemp = text2;
    }

    protected override void Interact2()
    {
        if (toSee)
        {
            game_opener.startGame();
        }
    }

    protected override string promptMessage()
    {
        return promptMessageTemp;
    }
}
