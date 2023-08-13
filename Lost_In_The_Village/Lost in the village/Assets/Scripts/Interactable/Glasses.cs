using TMPro;
using UnityEngine;

public class Glasses : AbstractInteractableObject
{
    [SerializeField] private CharacterMessage Orzel;
    [SerializeField] private TextMeshProUGUI destinationText;

    public static bool toSee = false;
    
    private string promptMessageTemp;
    private string text;

    void Start()
    {
        toSee = false;
    }

    void Update()
    {

    }

    protected override void Interact()
    {
        text = Helpers.Languages.SetTextPickUp();

        if (toSee)
            promptMessageTemp = text;
        else
            promptMessageTemp = "";
    }

    protected override void Interact2()
    {
        if (toSee)
        {
            gameObject.SetActive(false);
            Orzel.place = Place_enum.Orzel_glasses;
            setText();
        }
    }
    private void setText()
    {
        destinationText.text = Helpers.Languages.SetTextEagle();
    }

    protected override string promptMessage()
    {
        return promptMessageTemp;
    }
}
