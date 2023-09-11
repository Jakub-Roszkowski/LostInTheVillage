using UnityEngine;

namespace LostInTheVillage.Storyline.Village2
{
    public class Hello : MonoBehaviour
    {
        [SerializeField] private AudioSource BGM;
        [SerializeField] private AudioClip orzel;

        private void Start()
        {
            BGM.Stop();
        }

        public void OnTriggerEnter(Collider other)
        {
            ChangeBGM(orzel);
        }

        public void ChangeBGM(AudioClip music)
        {
            BGM.Stop();
            BGM.clip = music;
            BGM.Play();
        }
    }
}