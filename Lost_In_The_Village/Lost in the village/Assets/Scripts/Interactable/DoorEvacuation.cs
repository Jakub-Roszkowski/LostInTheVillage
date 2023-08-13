using UnityEngine;

public class DoorEvacuation : AbstractInteractableObject
{
    [SerializeField] private GameObject objectToActivate;
    [SerializeField] private GameObject[] objectsToDeactivate;

    public static bool toSee = false;

    private string promptMessageTemp;
    private string text;
    private string text2;

    private void Start()
    {
        toSee = false;
    }

    protected override void Interact()
    {
        text = Helpers.Languages.SetTextDoorEvacuationInteract();
        text2 = Helpers.Languages.SetTextDoorEvacuationInteract2();

        if (toSee)
            promptMessageTemp = text;
        else
            promptMessageTemp = text2;
    }

    protected override void Interact2()
    {
        if (toSee)
        {
            ActivateObjects();
        }
    }

    private void ActivateObjects()
    {
        if (objectToActivate != null)
        {
            objectToActivate.SetActive(true);
        }

        foreach (var obj in objectsToDeactivate)
        {
            if (obj != null)
            {
                obj.SetActive(false);
            }
        }
    }

    protected override string promptMessage()
    {
        return promptMessageTemp;
    }
}
