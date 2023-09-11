using System;
using UnityEngine;

namespace LostInTheVillage.MiniGames.Games.SuperPlatform.Scripts
{
    public class WelcomePanel : MonoBehaviour
    {
        public GameObject PanelNick;

        private void Update()
        {
            if (Input.GetKey(KeyCode.Return) || Input.GetKeyDown(KeyCode.Joystick1Button2))
            {
                PanelNick.SetActive(false);
                PlayerPlatform.start = true;
                PlayerPlatform.start_movement = true;

                PlayerPlatform.timestart = DateTime.Now;
            }
        }
    }
}
