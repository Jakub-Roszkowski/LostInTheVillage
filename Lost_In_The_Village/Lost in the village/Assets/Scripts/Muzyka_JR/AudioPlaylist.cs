using UnityEngine;

public class AudioPlaylist : MonoBehaviour
{
    public AudioClip[] audioClips;
    private AudioSource audioSource;
    private int currentClipIndex = 0;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        PlayNextClip();
    }

    private void PlayNextClip()
    {
        if (currentClipIndex >= audioClips.Length)
        {
            currentClipIndex = 0; // Wraca do pocz�tku playlisty, gdy sko�czy si� ostatni utw�r
        }

        audioSource.clip = audioClips[currentClipIndex];
        audioSource.Play();

        currentClipIndex++;
    }

    private void Update()
    {
        if (!audioSource.isPlaying)
        {
            PlayNextClip();
        }
    }
}
