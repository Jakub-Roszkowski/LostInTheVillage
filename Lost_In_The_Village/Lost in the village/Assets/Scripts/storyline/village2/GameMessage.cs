using TMPro;
using UnityEngine;

namespace LostInTheVillage.Storyline.Village2
{
    public class GameMessage : MonoBehaviour
    {
        [SerializeField] private Canvas canvasToActivate;

        [SerializeField] private AudioSource BGM;
        [SerializeField] private AudioClip messageAudio;

        [SerializeField] private TextMeshProUGUI promptText;
        [SerializeField] private TextMeshProUGUI textInMessage;

        private PlayerInput.OnFootActions onFoot;

        private bool visited = false;
        private PlayerInput playerInput;

        private void Awake()
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

                    ChangeBGM(messageAudio);
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
            promptText.text = LostInTheVillage.Helpers.Languages.SetTextGameInteract();

        }
        private void setTextInMessage()
        {
            textInMessage.text = LostInTheVillage.Helpers.Languages.SetTextGameMessage();
        }
    }
}