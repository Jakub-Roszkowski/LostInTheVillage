using LostInTheVillage.Helpers.Translations.CharacterTranslate;
using LostInTheVillage.Storyline.Wine;
using System.Collections;
using TMPro;
using UnityEngine;

namespace LostInTheVillage.Character
{
    public enum PlaceEnum
    {
        Welcome_Village2,
        Bar1,
        Bar2,
        Roszkol1,
        Roszkol2,
        OrzelWelcome,
        OrzelGlasses,
        OrzelTunel,
        OrzelLaptop,
        Village1,
        Village1Man,
    }

    public class CharacterMessage : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI promptText;
        [SerializeField] private TextMeshProUGUI destination;
        [SerializeField] private CharacterSounds sounds;
        [SerializeField] private AudioSource BGM;
        [SerializeField] private PlaceEnum place;

        public PlaceEnum Place { get; set; }
        public static bool IsMusicDown { get; private set; } = false;

        private AudioClip messageAudio;
        private string promptString;
        private string destinationString;

        private Transform cameraTransform;
        private Quaternion initialRotation;
        private float rotationSpeed = 2f;
        private Animator animator;

        private void Start()
        {
            Place = place;
            GameObject mainCamera = GameObject.FindWithTag("MainCamera");
            if (mainCamera != null)
            {
                cameraTransform = mainCamera.transform;
            }
            initialRotation = transform.rotation;
            animator = GetComponent<Animator>();
        }

        private void Update()
        {
            if (IsMusicDown)
            {
                if (cameraTransform != null)
                {
                    Vector3 lookDirection = cameraTransform.position - transform.position;
                    lookDirection.y = 0f;

                    Quaternion targetRotation = Quaternion.LookRotation(lookDirection.normalized, transform.up);
                    transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, targetRotation.eulerAngles.y, transform.rotation.eulerAngles.z);
                }
            }
            else
            {
                transform.rotation = Quaternion.Lerp(transform.rotation, initialRotation, rotationSpeed * Time.deltaTime);

                if (Quaternion.Angle(transform.rotation, initialRotation) < 1f)
                {
                    transform.rotation = initialRotation;
                }
            }
        }

        public void Message()
        {
            SelectTextMessage();

            destination.text = destinationString;

            ChangeBGM(messageAudio);
            if (!(Place == PlaceEnum.Village1))
            {
                StartCoroutine(WaitingFun(messageAudio.length));
            }
            else
            {
                StartCoroutine(WaitingFunVillage(messageAudio.length));
            }
        }


        private IEnumerator WaitingFun(float messageDuration)
        {
            yield return StartCoroutine(ShowMessage(messageDuration));
            HandleMessageCompletion();
            yield return StartCoroutine(HideMessage());
        }

        private IEnumerator WaitingFunVillage(float time1)
        {
            IsMusicDown = true;
            promptText.text = promptString;
            yield return new WaitForSeconds(time1);
            yield return new WaitForSeconds(2.0f);
            promptText.text = "";
            IsMusicDown = false;
        }

        private IEnumerator ShowMessage(float messageDuration)
        {
            IsMusicDown = true;
            promptText.text = promptString;
            animator.SetBool("is_talk", true);
            yield return new WaitForSeconds(messageDuration);
            animator.SetBool("is_talk", false);
        }

        private void HandleMessageCompletion()
        {
            if (Place == PlaceEnum.Bar1)
            {
                GoToWine gotowine = GetComponent<GoToWine>();
                gotowine.MoveToDestination();
            }
            else if (Place == PlaceEnum.Bar2)
            {
                GoToWine gotowine = GetComponent<GoToWine>();
                gotowine.MoveToDestination2();
            }
            else if (Place == PlaceEnum.OrzelWelcome || Place == PlaceEnum.OrzelGlasses || Place == PlaceEnum.OrzelTunel || Place == PlaceEnum.OrzelLaptop)
            {
                GoToPlayer goToPlayer = GetComponent<GoToPlayer>();
                goToPlayer.IsToGo = true;
            }
        }

        private IEnumerator HideMessage()
        {
            yield return new WaitForSeconds(1.0f);
            promptText.text = "";
            IsMusicDown = false;
        }

        private void ChangeBGM(AudioClip music)
        {
            BGM.Stop();
            BGM.clip = music;
            BGM.Play();
        }

        private void SelectTextMessage()
        {
            (messageAudio, promptString, destinationString) = CharacterTranslate.Translate(Place, sounds);
        }
    }
}
