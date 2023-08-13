using UnityEngine;

public class Sounds : MonoBehaviour
{
    private AudioSource audioSource;
    private float volume;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        volume = audioSource.volume;
    }

    void Update()
    {
        if (Pause.GameIsPaused)
        {
            audioSource.volume = 0f;
        }
        else
        {
            audioSource.volume = volume;
        }

        if (Pause.SoundisMute)
        {
            audioSource.volume = 0f;
        }
        else
        {
            audioSource.volume = volume;
        }
    }
}
