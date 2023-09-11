using LostInTheVillage.Menus;
using TMPro;
using UnityEngine;

namespace Minigames.Games.SuperPlatform.Scripts
{
    public class Music : MonoBehaviour
    {
        public TMP_Text Mute_TMP;
        public AudioSource BGM;
        public GameObject muteSounds_button;

        private bool mute = false;

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
