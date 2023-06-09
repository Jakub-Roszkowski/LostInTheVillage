using UnityEngine;

public class AudioPlaylist : MonoBehaviour
{
    public AudioClip[] audioClips;
    private AudioSource audioSource;
    private int currentClipIndex = 0;
    private float glosnosc;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        PlayNextClip();
        glosnosc = audioSource.volume;
    }

    private void PlayNextClip()
    {
        if (currentClipIndex >= audioClips.Length)
        {
            currentClipIndex = 0; // Wraca do pocz¹tku playlisty, gdy skoñczy siê ostatni utwór
        }

        audioSource.clip = audioClips[currentClipIndex];
        audioSource.Play();

        currentClipIndex++;
    }

    private void Update()
    {
        if (Pause.MusicisMute)
        {
            audioSource.volume = 0f;
        }
        else
        {
            audioSource.volume = glosnosc;
        }
        if (!audioSource.isPlaying)
        {
            PlayNextClip();
        }
    }
}
