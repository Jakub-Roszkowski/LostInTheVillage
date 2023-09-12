using Assets.MiniGames.Games.Milioneirs.Scripts.Lifebuoys;
using LostInTheVillage.Helpers.Translations;
using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace LostInTheVillage.MiniGames.Games.Milioneirs.Scripts
{
    public class QuestionController : MonoBehaviour
    {
        [SerializeField] private TMP_Text question;
        [SerializeField] private TMP_Text answerA;
        [SerializeField] private TMP_Text answerB;
        [SerializeField] private TMP_Text answerC;
        [SerializeField] private TMP_Text answerD;
        [SerializeField] private TMP_Text timeShow;
        [SerializeField] private GameObject frameAnswerA;
        [SerializeField] private GameObject frameAnswerB;
        [SerializeField] private GameObject frameAnswerC;
        [SerializeField] private GameObject frameAnswerD;
        [SerializeField] private GameObject buttonFinish;
        [SerializeField] private GameObject button50;
        [SerializeField] private GameObject frameFinish;
        [SerializeField] private TMP_Text text;
        [SerializeField] private TMP_Text winValue;

        public static string Nick { get; set; }
        public static bool IsLose { get; private set; } = false;
        public static bool IsTime { get; set; } = false;
        public static DateTime timestart { get; set; }

        private static bool isButtonsActive = true;
        private static bool isSecondLifebuoysActive = true;

        private string finishMessage;

        private int timeToAnswer = 25;
        private DateTime timeToAnswerHelper;

        private void Start()
        {
            SetInitialGameSettings();
            SetUIElements();
            AssignButtonListeners();
        }

        private void Update()
        {
            UpdateTimeToAnswer();
            HandleSecondLifebuoyInput();
            HandleFinishInput();
            HandleAnswerInput();
            CheckForTextUpdate();
        }

        public static void DisabelFiftyFifty()
        {
            isSecondLifebuoysActive = false;
        }

        #region Start
        private void SetInitialGameSettings()
        {
            isButtonsActive = true;
            isSecondLifebuoysActive = true;
            IsTime = false;
            IsLose = false;
        }

        private void SetUIElements()
        {
            frameFinish.SetActive(false);
            text.text = Nick + LanguagesTranslation.SetTextWin();
            winValue.text = MilioneirsQuestions.guaranteedWIN.ToString();
            question.text = MilioneirsQuestions.CurrentQuestion;
            answerA.text = MilioneirsQuestions.CurrentAnswerA;
            answerB.text = MilioneirsQuestions.CurrentAnswerB;
            answerC.text = MilioneirsQuestions.CurrentAnswerC;
            answerD.text = MilioneirsQuestions.CurrentAnswerD;
        }

        private void AssignButtonListeners()
        {
            frameAnswerA.transform.GetComponent<Button>().onClick.AddListener(OnClickA);
            frameAnswerB.transform.GetComponent<Button>().onClick.AddListener(OnClickB);
            frameAnswerC.transform.GetComponent<Button>().onClick.AddListener(OnClickC);
            frameAnswerD.transform.GetComponent<Button>().onClick.AddListener(OnClickD);
            buttonFinish.transform.GetComponent<Button>().onClick.AddListener(MessageFinish);
            button50.transform.GetComponent<Button>().onClick.AddListener(FiftyFifty.Message50);
        }
        #endregion 
        #region Update
        private void UpdateTimeToAnswer()
        {
            timeToAnswerHelper = DateTime.Now;
            if (IsTime)
            {
                if (timestart.AddSeconds(timeToAnswer) < timeToAnswerHelper)
                {
                    timeShow.text = "";
                    DisplayCorrectValue();
                    MessageFinish();
                    IsLose = true;
                }
                else
                {
                    timeShow.text = (timestart.AddSeconds(timeToAnswer) - timeToAnswerHelper).Seconds.ToString();
                }
            }
        }

        private void HandleSecondLifebuoyInput()
        {
            if (isSecondLifebuoysActive)
            {
                if (Input.GetKeyDown(KeyCode.F2))
                {
                    FiftyFifty.Message50();
                }
            }
            else
            {
                button50.SetActive(false);
            }
        }

        private void HandleFinishInput()
        {
            if (Input.GetKeyDown(KeyCode.F4))
            {
                MessageFinish();
            }
        }

        private void HandleAnswerInput()
        {
            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.Alpha1))
            {
                OnClickA();
            }
            if (Input.GetKeyDown(KeyCode.B) || Input.GetKeyDown(KeyCode.Alpha2))
            {
                OnClickB();
            }
            if (Input.GetKeyDown(KeyCode.C) || Input.GetKeyDown(KeyCode.Alpha3))
            {
                OnClickC();
            }
            if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.Alpha4))
            {
                OnClickD();
            }
        }

        private void CheckForTextUpdate()
        {
            if (text)
            {
                Next();
            }
        }
        #endregion
        #region AnswerClick
        private void OnAnswerClick(string selectedAnswer, GameObject frameAnswer)
        {
            if (isButtonsActive)
            {
                if (MilioneirsQuestions.CurrentAnswer == selectedAnswer)
                {

                    frameAnswer.transform.GetComponent<Image>().color = Color.green;

                    StartCoroutine(NextQuestion());
                    CheckMillion();
                    timestart = DateTime.Now;
                }
                else
                {
                    frameAnswer.transform.GetComponent<Image>().color = Color.red;

                    DisplayCorrectValue();
                    MessageFinish();
                    IsLose = true;
                }
            }
        }

        private void OnClickA()
        {
            OnAnswerClick("A", frameAnswerA);
        }

        private void OnClickB()
        {
            OnAnswerClick("B", frameAnswerB);
        }

        private void OnClickC()
        {
            OnAnswerClick("C", frameAnswerC);
        }

        private void OnClickD()
        {
            OnAnswerClick("D", frameAnswerD);
        }
        #endregion

        private void DisplayCorrectValue()
        {
            if (MilioneirsQuestions.CurrentAnswer == "A")
                frameAnswerA.transform.GetComponent<Image>().color = Color.green;
            else if (MilioneirsQuestions.CurrentAnswer == "B")
                frameAnswerB.transform.GetComponent<Image>().color = Color.green;
            else if (MilioneirsQuestions.CurrentAnswer == "C")
                frameAnswerC.transform.GetComponent<Image>().color = Color.green;
            else if (MilioneirsQuestions.CurrentAnswer == "D")
                frameAnswerD.transform.GetComponent<Image>().color = Color.green;
        }

        private IEnumerator NextQuestion()
        {
            MilioneirsQuestions.CurrentPosition++;

            isButtonsActive = false;

            yield return new WaitForSeconds(3);
            MilioneirsQuestions.NextQuestion();

            frameAnswerA.transform.GetComponent<Image>().color = new Color(0.1059f, 0.2863f, 0.8196f);
            frameAnswerB.transform.GetComponent<Image>().color = new Color(0.1059f, 0.2863f, 0.8196f);
            frameAnswerC.transform.GetComponent<Image>().color = new Color(0.1059f, 0.2863f, 0.8196f);
            frameAnswerD.transform.GetComponent<Image>().color = new Color(0.1059f, 0.2863f, 0.8196f);

            isButtonsActive = true;
        }

        private void Next()
        {
            question.text = MilioneirsQuestions.CurrentQuestion;
            answerA.text = MilioneirsQuestions.CurrentAnswerA;
            answerB.text = MilioneirsQuestions.CurrentAnswerB;
            answerC.text = MilioneirsQuestions.CurrentAnswerC;
            answerD.text = MilioneirsQuestions.CurrentAnswerD;
        }

        private void CheckMillion()
        {
            if (MilioneirsQuestions.CurrentPosition >= 13)
            {
                frameFinish.SetActive(true);
                winValue.text = 1000000.ToString();
                IsTime = false;
            }
        }

        private void MessageFinish()
        {
            text.text = Nick + finishMessage;
            frameFinish.SetActive(true);
            winValue.text = MilioneirsQuestions.potentialWIN.ToString();
            IsTime = false;
            DisableButtons();
        }

        private void DisableButtons()
        {
            isButtonsActive = false;
        }
    }
}

