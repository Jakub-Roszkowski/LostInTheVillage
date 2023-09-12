using LostInTheVillage.Helpers;
using LostInTheVillage.Helpers.Translations;
using LostInTheVillage.Menus;
using LostInTheVillage.MiniGames.RemoveDontDestroy;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace LostInTheVillage.MiniGames.Games.Milioneirs.Scripts
{
    public class Question
    {
        public string QuestionText { get; }
        public string AnswerA { get; }
        public string AnswerB { get; }
        public string AnswerC { get; }
        public string AnswerD { get; }
        public string Answer { get; }

        public Question(string question, string answearA, string answearB, string answearC, string answearD, string answear)
        {
            QuestionText = question;
            AnswerA = answearA;
            AnswerB = answearB;
            AnswerC = answearC;
            AnswerD = answearD;
            Answer = answear;
        }
    }

    public class MilioneirsQuestions : MonoBehaviour
    {
        public static int CurrentPosition { get; set; } = 1;
        public static string CurrentQuestion { get; private set; } = "";
        public static string CurrentAnswerA { get; set; } = "";
        public static string CurrentAnswerB { get; set; } = "";
        public static string CurrentAnswerC { get; set; } = "";
        public static string CurrentAnswerD { get; set; } = "";
        public static string CurrentAnswer { get; private set; } = "";
        public static int guaranteedWIN { get; private set; } = 0;
        public static int potentialWIN { get; private set; } = 0;

        private static List<Question> hard1 = new List<Question>();
        private static List<Question> hard2 = new List<Question>();
        private static List<Question> hard3 = new List<Question>();
        private static List<Question> hard4 = new List<Question>();
        private static List<Question> hard5 = new List<Question>();
        private static List<Question> hard6 = new List<Question>();
        private static List<Question> hard7 = new List<Question>();
        private static List<Question> hard8 = new List<Question>();
        private static List<Question> hard9 = new List<Question>();
        private static List<Question> hard10 = new List<Question>();
        private static List<Question> hard11 = new List<Question>();
        private static List<Question> hard12 = new List<Question>();

        private void Start()
        {
            (hard1, hard2, hard3, hard4, hard5, hard6, hard7, hard8, hard9, hard10, hard11, hard12) = MilioneirsQuestionsTranslate.Translate();

            CurrentPosition = 1;

            NextQuestion();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.F8))
            {
                Retry();
            }

            if (Input.GetKeyDown(KeyCode.F9))
            {
                Time.timeScale = 1f;
                foreach (GameObject obj in MoveDontDestroyOnLoadObjects.dontDestroyObjects)
                {
                    obj.SetActive(true);
                }
                SceneManager.LoadScene(Scenes.Empty);
                MiniGameMenu.IsInGame2 = true;
            }
        }

        public static void NextQuestion()
        {
            VauleuWON();
            System.Random rnd = new System.Random();

            List<List<Question>> questionLists = new List<List<Question>>
            {
                hard1, hard2, hard3, hard4, hard5, hard6, hard7, hard8, hard9, hard10, hard11, hard12
            };

            int listIndex = CurrentPosition - 1;
            List<Question> questionList = questionLists[listIndex];

            int random = rnd.Next(questionList.Count);
            Question selectedQuestion = questionList[random];

            CurrentQuestion = selectedQuestion.QuestionText;
            CurrentAnswerA = selectedQuestion.AnswerA;
            CurrentAnswerB = selectedQuestion.AnswerB;
            CurrentAnswerC = selectedQuestion.AnswerC;
            CurrentAnswerD = selectedQuestion.AnswerD;
            CurrentAnswer = selectedQuestion.Answer;
        }

        private void Retry()
        {
            Time.timeScale = 1f;
            foreach (GameObject obj in MoveDontDestroyOnLoadObjects.dontDestroyObjects)
            {
                obj.SetActive(true);
            }
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        private static void VauleuWON()
        {
            int[] potentialWINS = { 0, 0, 500, 1000, 2000, 5000, 10000, 20000, 50000, 75000, 150000, 250000, 500000 };

            if (CurrentPosition >= 0 && CurrentPosition < potentialWINS.Length)
            {
                potentialWIN = potentialWINS[CurrentPosition];

                if (CurrentPosition < 3)
                {
                    guaranteedWIN = 0;
                }
                else if (CurrentPosition <= 7)
                {
                    guaranteedWIN = 1000;
                }
                else if (CurrentPosition <= 12)
                {
                    guaranteedWIN = 50000;
                }
            }
        }
    }
}
