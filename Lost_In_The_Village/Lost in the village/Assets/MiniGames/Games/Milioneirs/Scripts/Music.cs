using UnityEngine;

namespace LostInTheVillage.MiniGames.Games.Milioneirs.Scripts
{

    public class Music : MonoBehaviour
    {
        public AudioSource BGM;

        public void ChangeBGM(AudioClip music)
        {
            if (BGM.clip.name == music.name)
                return;

            BGM.Stop();
            BGM.clip = music;
            BGM.Play();
        }
    }
}
