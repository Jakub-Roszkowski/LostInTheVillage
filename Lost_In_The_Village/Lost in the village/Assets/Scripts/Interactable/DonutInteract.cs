using LostInTheVillage.Helpers;
using LostInTheVillage.Interactable.Interface;
using LostInTheVillage.Menus;
using LostInTheVillage.Player;
using UnityEngine;

namespace LostInTheVillage.Interactable
{
    public class DonutInteract : AbstractInteractableObject
    {
        [SerializeField] private AudioSource eatingSound;

        private bool iseat = true;

        private string promptMessageTemp;

        private static int value = 20;

        private void Update()
        {
            if (Pause.CurrentLevel == Level.Easy)
            {
                value = ConfigNumbers.DonutRestorHpEasy;
            }
            if (Pause.CurrentLevel == Level.Medium)
            {
                value = ConfigNumbers.DonutRestorHpMedium;
            }
            if (Pause.CurrentLevel == Level.Hard)
            {
                value = ConfigNumbers.DonutRestorHpHard;
            }
        }

        protected override void Interact()
        {
            promptMessageTemp = Languages.SetTextDonut() + " " + value + " HP (E)";
        }

        protected override void Interact2()
        {
            Health playerHealth = GameObject.FindWithTag("Player").GetComponent<Health>();

            if (playerHealth != null && iseat)
            {
                playerHealth.RestoreHealth(value);
                eatingSound.Play();
                iseat = false;
                Destroy(gameObject, 1);
            }
        }

        protected override string PromptMessage()
        {
            return promptMessageTemp;
        }
    }
}
