using LostInTheVillage.Helpers;
using LostInTheVillage.Menus;
using LostInTheVillage.Player;
using System.Collections;
using UnityEngine;

namespace LostInTheVillage.Interactable
{
    public class AntiPersonnelMine : MonoBehaviour
    {
        [SerializeField] private ParticleSystem explosionParticle;
        [SerializeField] private AudioSource BGM;
        [SerializeField] private AudioClip explosionSound;

        private float damage;

        private void Start()
        {
            BGM.Stop();
            explosionParticle.Pause();
        }

        public void OnTriggerEnter(Collider other)
        {
            SetDamageBasedOnDifficulty();

            ChangeBGM(explosionSound);

            if (other.gameObject.CompareTag("Player"))
            {
                Health objectToDamage = other.GetComponent<Health>();
                objectToDamage.TakeDamage(damage);
            }

            StartCoroutine(DestroyObject());
        }
        private void SetDamageBasedOnDifficulty()
        {
            switch (Pause.CurrentLevel)
            {
                case Level.Easy:
                    damage = ConfigNumbers.MineHpEasy;
                    break;
                case Level.Medium:
                    damage = ConfigNumbers.MineHpMedium;
                    break;
                case Level.Hard:
                    damage = ConfigNumbers.MineHpHard;
                    break;
                default:
                    damage = 0f;
                    break;
            }
        }

        IEnumerator DestroyObject()
        {
            yield return new WaitForSeconds(4f);
            Destroy(gameObject);
        }

        public void ChangeBGM(AudioClip music)
        {
            BGM.Stop();
            BGM.clip = music;
            BGM.Play();
        }
    }
}

