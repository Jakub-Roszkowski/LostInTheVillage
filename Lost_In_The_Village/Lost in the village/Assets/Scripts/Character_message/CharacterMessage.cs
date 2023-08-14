using System.Collections;
using TMPro;
using UnityEngine;

public enum Place_enum
{
    Welcome_Village2,
    Bar1,
    Bar2,
    Roszkol1,
    Roszkol2,
    Orzel_welcome,
    Orzel_glasses,
    Orzel_tunel,
    Orzel_laptop,
    Village1,
    Village1Man,
}

public class CharacterMessage : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI promptText;
    [SerializeField] private TextMeshProUGUI destination;
    [SerializeField] private CharacterSounds sounds;

    public Place_enum place;
    public AudioSource BGM;

    public static bool isMusicDown = false;

    public AudioClip audio;
    private string promptString;
    private string destinationString;

    private Transform cameraTransform;
    private Quaternion initialRotation;
    private bool isRotating = false;
    private float rotationSpeed = 2f;
    private Animator animator;

    void Start()
    {
        GameObject mainCamera = GameObject.FindWithTag("MainCamera");
        if (mainCamera != null)
        {
            cameraTransform = mainCamera.transform;
        }
        initialRotation = transform.rotation;
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (isMusicDown)
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
                isRotating = false;
            }
        }
    }

    public void Message()
    {
        Select();

        destination.text = destinationString;

        ChangeBGM(audio);
        if (!(place == Place_enum.Village1))
        {
            StartCoroutine(waitingFun(audio.length));
        }
        else
        {
            StartCoroutine(waitingFunVillage(audio.length));
        }
    }

    IEnumerator waitingFun(float time1)
    {
        isMusicDown = true;
        promptText.text = promptString;
        animator.SetBool("is_talk", true);
        yield return new WaitForSeconds(time1);
        animator.SetBool("is_talk", false);

        yield return new WaitForSeconds(1.0f);

        if (place == Place_enum.Bar1)
        {
            GoToWine gotowine = GetComponent<GoToWine>();
            gotowine.MoveToDestination();
        }
        else if (place == Place_enum.Bar2)
        {
            GoToWine gotowine = GetComponent<GoToWine>();
            gotowine.MoveToDestination2();
        }

        else if (place == Place_enum.Orzel_welcome || place == Place_enum.Orzel_glasses || place == Place_enum.Orzel_tunel || place == Place_enum.Orzel_laptop)
        {
            GoToPlayer goToPlayer = GetComponent<GoToPlayer>();
            goToPlayer.isToGo = true;
        }
        yield return new WaitForSeconds(1.0f);
        promptText.text = "";
        isMusicDown = false;
    }

    IEnumerator waitingFunVillage(float time1)
    {
        isMusicDown = true;
        promptText.text = promptString;
        yield return new WaitForSeconds(time1);
        yield return new WaitForSeconds(2.0f);
        promptText.text = "";
        isMusicDown = false;
    }

    private void ChangeBGM(AudioClip music)
    {
        BGM.Stop();
        BGM.clip = music;
        BGM.Play();
    }

    private void Select()
    {
        (audio, promptString, destinationString) = Helpers.CharacterTranslate.Translate(place, sounds);
    }
}
