using LostInTheVillage.Menus;
using UnityEngine;

namespace Minigames.Games.SuperPlatform.Scripts
{
    public class Music : MonoBehaviour
    {
        private AudioSource audioSource;
        private float startVolume;

        private void Start()
        {
            audioSource = GetComponent<AudioSource>();
            startVolume = audioSource.volume;
        }

        private void Update()
        {
            if (Pause.MusicIsMute)
            {
                audioSource.volume = 0f;
            }
            else
            {
                audioSource.volume = startVolume;
            }
        }
    }
}
