using TMPro;
using UnityEngine;

public class LaptopInteractable : AbstractInteractableObject
{
    [SerializeField] private GameObject[] objectsToDeactivate;
    [SerializeField] private CharacterMessage Orzel;
    [SerializeField] private TextMeshProUGUI destinationText;

    public static bool toSee = false;

    private string promptMessageTemp;
    private string text;
    private string text2;

    private void Start()
    {
        toSee = false;
    }
    private void DisableObjects()
    {
        foreach (var obj in objectsToDeactivate)
        {
            if (obj != null)
            {
                obj.SetActive(false);
            }
        }
    }

    protected override void Interact()
    {
        text = Helpers.Languages.SetTextLaptopInteract();
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
            DisableObjects();
            Orzel.place = Place_enum.Orzel_laptop;
            setText();
            DoorEvacuation.toSee = true;
            toSee = false;
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
