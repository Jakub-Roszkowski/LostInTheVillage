using LostInTheVillage.Character;
using LostInTheVillage.Helpers;
using LostInTheVillage.Menus;
using UnityEngine;

namespace LostInTheVillage.Music
{
    public class AudioPlaylist : MonoBehaviour
    {
        [SerializeField] private AudioClip[] audioClips;

        private AudioSource audioSource;
        private int currentClipIndex = 0;
        private float startingVolume;

        private void Start()
        {
            audioSource = GetComponent<AudioSource>();
            PlayNextClip();
            startingVolume = audioSource.volume;
        }

        private void PlayNextClip()
        {
            if (currentClipIndex >= audioClips.Length)
            {
                currentClipIndex = 0;
            }

            audioSource.clip = audioClips[currentClipIndex];
            audioSource.Play();

            currentClipIndex++;
        }

        private void Update()
        {
            if (Pause.MusicIsMute)
            {
                audioSource.volume = 0f;
            }
            else if (CharacterMessage.IsMusicDown)
            {
                audioSource.volume = startingVolume * ConfigNumbers.MusicMuteVolume;
            }
            else
            {
                audioSource.volume = startingVolume;
            }

            if (!audioSource.isPlaying)
            {
                PlayNextClip();
            }
        }
    }
}
