using LostInTheVillage.MiniGames.Games.Milioneirs.Scripts;
using System.Collections;
using UnityEngine;

namespace Assets.MiniGames.Games.Milioneirs.Scripts.Lifebuoys
{
    public static class FiftyFifty
    {
        public static void Message50()
        {
            ArrayList answers50 = new ArrayList
            {
                "A",
                "B",
                "C",
                "D"
            };

            System.Random rnd = new System.Random();
            int random2 = rnd.Next(3);

            string correct = MilioneirsQuestions.CurrentAnswer;
            answers50.Remove(correct);
            string answer = (string)answers50[random2];
            Debug.Log("onclick" + (string)answers50[0] + " " + (string)answers50[1]);

            if ((string)answers50[0] == "A" || (string)answers50[1] == "A")
            {
                MilioneirsQuestions.CurrentAnswerA = "";
            }
            if ((string)answers50[0] == "B" || (string)answers50[1] == "B")
            {
                MilioneirsQuestions.CurrentAnswerB = "";
            }
            if ((string)answers50[0] == "C" || (string)answers50[1] == "C")
            {
                MilioneirsQuestions.CurrentAnswerC = "";
            }
            if ((string)answers50[0] == "D" || (string)answers50[1] == "D")
            {
                MilioneirsQuestions.CurrentAnswerD = "";
            }

            QuestionController.DisabelFiftyFifty();
        }
    }
}
