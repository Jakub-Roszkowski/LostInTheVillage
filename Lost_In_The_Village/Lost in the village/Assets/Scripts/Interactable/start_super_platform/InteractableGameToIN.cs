public class InteractableGameToIN : AbstractInteractableObject
{
    public string promptMessageTemp;
    public bool to_see = true;

    private GameOpenerSuperPlatform game_opener;
    private string text;

    void Start()
    {
        game_opener = GetComponent<GameOpenerSuperPlatform>();
        to_see = true;
    }

    void Update()
    {
    }

    protected override void Interact()
    {
        text = Helpers.Languages.SetTextGameToIn();

        if (to_see)
            promptMessageTemp = text;
        else
            promptMessageTemp = "";
    }

    protected override void Interact2()
    {
        if (to_see)
        {
            game_opener.startGame();
        }
    }

    protected override string promptMessage()
    {
        return promptMessageTemp;
    }
}
