using TMPro;
using UnityEngine;

public class Plotka : AbstractInteractableObject
{
    [SerializeField] private GameObject objToActive;
    [SerializeField] private TextMeshProUGUI destinationText;
    [SerializeField] private CharacterMessage Roszkol;

    public static bool toFeed;

    private string promptMessageTemp;

    void Start()
    {
        toFeed = false;
    }
    void Update()
    {
    }

    protected override void Interact()
    {
        if (toFeed)
            promptMessageTemp = Helpers.Languages.SetTextFeed();
        else
            promptMessageTemp = "";
    }

    protected override void Interact2()
    {
        if (toFeed)
        {
            objToActive.SetActive(true);
            gameObject.SetActive(false);
            Roszkol.place = Place_enum.Roszkol2;
            setText();
        }
    }

    private void setText()
    {
        destinationText.text = Helpers.Languages.SetTextFindRoszkol();
    }

    protected override string promptMessage()
    {
        return promptMessageTemp;
    }
}
