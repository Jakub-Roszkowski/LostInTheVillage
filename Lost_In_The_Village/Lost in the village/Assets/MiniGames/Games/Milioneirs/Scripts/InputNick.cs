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
            theName = " ";
        }

        private void Update()
        {
            if (Input.GetKey(KeyCode.Return))
            {
                theName = input.text;
                panelNick.SetActive(false);


                QuestionController.Nick = theName;
                IsStart = true;
                QuestionController.IsTime = true;

                QuestionController.timestart = DateTime.Now;
            }
        }
    }
}
