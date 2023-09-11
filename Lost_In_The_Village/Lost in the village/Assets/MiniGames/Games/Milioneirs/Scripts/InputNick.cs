using System;
using TMPro;
using UnityEngine;

namespace LostInTheVillage.MiniGames.Games.Milioneirs.Scripts
{
    public class InputNick : MonoBehaviour
    {        
        [SerializeField] private TMP_InputField input;
        [SerializeField] private GameObject panelNick;
        public static bool IsStart { get; private set; }

        private static string theName = " ";

        private void Start()
        {
            IsStart = false;
        }

        private void Update()
        {
            if (Input.GetKey(KeyCode.Return))
            {
                theName = input.text;
                panelNick.SetActive(false);

                QestionText.Nick = theName;
                IsStart = true;
                QestionText.timeif = true;

                QestionText.timestart = DateTime.Now;
            }
        }
    }
}
