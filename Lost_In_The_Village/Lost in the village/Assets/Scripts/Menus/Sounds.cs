using UnityEngine;

namespace LostInTheVillage.Menus
{
    public class Sounds : MonoBehaviour
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
            if (Pause.GameIsPaused)
            {
                audioSource.volume = 0f;
            }
            else
            {
                audioSource.volume = startVolume;
            }

            if (Pause.SoundIsMute)
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
