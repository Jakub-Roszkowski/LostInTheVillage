using LostInTheVillage.Helpers;
using LostInTheVillage.Interactable.Interface;
using LostInTheVillage.Storyline.Village2;
using TMPro;
using UnityEngine;

namespace LostInTheVillage.Interactable
{
    public class Control : AbstractInteractableObject
    {
        [SerializeField] private Canvas canvasToActivate;
        [SerializeField] private TextMeshProUGUI textCanvas;

        [SerializeField] private AudioSource BGM;
        [SerializeField] private AudioClip messageAudio;

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
                DeactivateCanvas();
            }
        }

        protected override void Interact()
        {
            text = Languages.SetTextControlInteract();
            promptMessageTemp = text;
        }

        protected override void Interact2()
        {
            ChangeBGM(messageAudio);
            ActivateCanvas();
            SetText();
        }


        private void SetText()
        {
            textCanvas.text = Languages.SetTextControl();
        }

        private void ChangeBGM(AudioClip music)
        {
            BGM.Stop();
            BGM.clip = music;
            BGM.Play();
        }

        protected override string PromptMessage()
        {
            return promptMessageTemp;
        }

        private void ActivateCanvas()
        {
            if (canvasToActivate != null)
            {
                canvasToActivate.gameObject.SetActive(true);
            }
        }

        private void DeactivateCanvas()
        {
            if (canvasToActivate != null)
            {
                canvasToActivate.gameObject.SetActive(false);
            }
        }
    }
}