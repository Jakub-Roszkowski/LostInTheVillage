using System;
using UnityEngine;

namespace LostInTheVillage.MiniGames.Games.SuperPlatform.Scripts
{
    public class WelcomePanel : MonoBehaviour
    {
        [SerializeField] private GameObject PanelNick;

        private void Update()
        {
            if (Input.GetKey(KeyCode.Return) || Input.GetKeyDown(KeyCode.Joystick1Button2))
            {
                PanelNick.SetActive(false);
                PlayerPlatformController.IsStart = true;
                PlayerPlatformController.IsStartMovement = true;

                PlayerPlatformController.TimeStart = DateTime.Now;
            }
        }
    }
}
