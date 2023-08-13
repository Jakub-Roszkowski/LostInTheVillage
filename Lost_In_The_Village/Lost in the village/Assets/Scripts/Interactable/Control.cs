using TMPro;
using UnityEngine;

public class Control : AbstractInteractableObject
{
    [SerializeField] private Canvas canvasToActivate;
    [SerializeField] private TextMeshProUGUI textCanva;

    [SerializeField] private AudioSource BGM;
    [SerializeField] private AudioClip message;

    private InputManagerToExitCanva inputManager;
    private string text;
    private string promptMessageTemp;

    private void Start()
    {
        BGM.Stop();
        inputManager = GetComponent<InputManagerToExitCanva>();
    }

    private void Update()
    {
        if (inputManager.onFoot.Exit.triggered)
        {
            canvasToActivate.gameObject.SetActive(false);
        }
    }

    protected override void Interact()
    {
        text = Helpers.Languages.SetTextControlInteract();
        promptMessageTemp = text;
    }

    protected override void Interact2()
    {
        ChangeBGM(message);
        canvasToActivate.gameObject.SetActive(true);
        SetText();
    }


    private void SetText()
    {
        textCanva.text = Helpers.Languages.SetTextControl();
    }

    public void ChangeBGM(AudioClip music)
    {
        BGM.Stop();
        BGM.clip = music;
        BGM.Play();
    }

    protected override string promptMessage()
    {
        return promptMessageTemp;
    }
}