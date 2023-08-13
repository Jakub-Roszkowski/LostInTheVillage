using TMPro;
using UnityEngine;

public class GameMessage : MonoBehaviour
{
    [SerializeField] private Canvas canvasToActivate;

    [SerializeField] private AudioSource BGM;
    [SerializeField] private AudioClip wiadomosc;

    [SerializeField] private TextMeshProUGUI promptText;
    [SerializeField] private TextMeshProUGUI textInMessage;

    public PlayerInput.OnFootActions onFoot;

    private bool visited = false;
    private PlayerInput playerInput;

    void Awake()
    {
        playerInput = new PlayerInput();
        onFoot = playerInput.OnFoot;

    }

    private void OnEnable()
    {
        onFoot.Enable();
    }

    private void OnDisable()
    {
        onFoot.Disable();
    }

    private void Start()
    {
        BGM.Stop();
    }

    private void Update()
    {
        if (onFoot.Exit.triggered)
        {
            canvasToActivate.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!visited)
        {
            if (other.CompareTag("Player"))
            {

                ChangeBGM(wiadomosc);
                canvasToActivate.gameObject.SetActive(true);
                setText();
                setTextInMessage();

                visited = true;

            }
        }
    }

    public void ChangeBGM(AudioClip music)
    {
        BGM.Stop();
        BGM.clip = music;
        BGM.Play();
    }

    private void setText()
    {
        promptText.text = Helpers.Languages.SetTextGameInteract();

    }
    private void setTextInMessage()
    {
        textInMessage.text = Helpers.Languages.SetTextGameMessage();
    }
}



