using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using LostInTheVillage.Helpers;

namespace LostInTheVillage.MiniGames.Games.Milioneirs.Scripts
{
    public class QestionText : MonoBehaviour
    {
        public TMP_Text Question;
        public TMP_Text AnswearA;
        public TMP_Text AnswearB;
        public TMP_Text AnswearC;
        public TMP_Text AnswearD;

        public TMP_Text timeShow;

        public GameObject FrameAnswearA;
        public GameObject FrameAnswearB;
        public GameObject FrameAnswearC;
        public GameObject FrameAnswearD;

        public GameObject ButtonFinish;
        public GameObject Button50;

        int random2 = 0;
        string answear;

        static bool iftext;

        ArrayList answears = new ArrayList();

        public GameObject FrameLose2;
        public TMP_Text text;
        public TMP_Text Value;

        public string corect;

        public static string Nick { get; set; }
        public static bool lose = false;
        public static bool timeif = false;
        public static bool f2 = true;
        public static bool buttonsActive = true;

        string q;
        string qa;
        string qb;
        string qc;
        string qd;

        System.DateTime time;
        public static System.DateTime timestart;

        private string text1;
        private int timeToAnswear = 25;

        private void Start()
        {
            buttonsActive = true;
            f2 = true;
            iftext = false;
            timeif = false;
            timestart = DateTime.Now;

            System.Random rnd = new System.Random();
            random2 = rnd.Next(3);

            answears.Add("A");
            answears.Add("B");
            answears.Add("C");
            answears.Add("D");

            FrameLose2.SetActive(false);
            text.text = Nick + Languages.SetTextWin();
            Value.text = TestMilioneirs.guaranteedWIN.ToString();

            lose = false;

            Question.text = TestMilioneirs.CurrentQuestion;
            AnswearA.text = TestMilioneirs.CurrentAnswearA;
            AnswearB.text = TestMilioneirs.CurrentAnswearB;
            AnswearC.text = TestMilioneirs.CurrentAnswearC;
            AnswearD.text = TestMilioneirs.CurrentAnswearD;

            FrameAnswearA.transform.GetComponent<Button>().onClick.AddListener(OnClickA);
            FrameAnswearB.transform.GetComponent<Button>().onClick.AddListener(OnClickB);
            FrameAnswearC.transform.GetComponent<Button>().onClick.AddListener(OnClickC);
            FrameAnswearD.transform.GetComponent<Button>().onClick.AddListener(OnClickD);
            ButtonFinish.transform.GetComponent<Button>().onClick.AddListener(MessageWin);
            Button50.transform.GetComponent<Button>().onClick.AddListener(Message50);

            text1 = Languages.SetTextWin();
        }

        private void Update()
        {
            corect = TestMilioneirs.CurrentAnswear;
            time = DateTime.Now;

            if (f2)
            {
                if (Input.GetKeyDown(KeyCode.F2))
                {
                    Message50();
                }
            }

            if (Input.GetKeyDown(KeyCode.F4))
            {
                MessageWin();
            }

            if (timeif)
            {
                if (timestart.AddSeconds(timeToAnswear) < time)
                {
                    CorectValue();
                    Message();
                    lose = true;
                }
                if ((timestart.AddSeconds(15) - time) >= TimeSpan.Zero)
                {
                    timeShow.text = (timestart.AddSeconds(15) - time).Seconds.ToString();
                }
                else
                {
                    timeShow.text = "";
                }
            }

            q = TestMilioneirs.CurrentQuestion;
            qa = TestMilioneirs.CurrentAnswearA;
            qb = TestMilioneirs.CurrentAnswearB;
            qc = TestMilioneirs.CurrentAnswearC;
            qd = TestMilioneirs.CurrentAnswearD;

            if (text) { Next(); }
        }

        private void OnClickA()
        {
            if (buttonsActive)
            {
                if (TestMilioneirs.CurrentAnswear == "A")
                {
                    FrameAnswearA.transform.GetComponent<Image>().color = Color.green;
                    SomeMethod();
                    Checkmilion();

                    timestart = DateTime.Now;
                }
                else
                {
                    FrameAnswearA.transform.GetComponent<Image>().color = Color.red;
                    CorectValue();
                    Message();
                    lose = true;
                }
                FrameAnswearA.SetActive(true);
            }
        }
        private void OnClickB()
        {
            if (buttonsActive)
            {
                if (TestMilioneirs.CurrentAnswear == "B")
                {
                    FrameAnswearB.transform.GetComponent<Image>().color = Color.green;
                    SomeMethod();
                    Checkmilion();
                    timestart = DateTime.Now;
                }
                else
                {
                    FrameAnswearB.transform.GetComponent<Image>().color = Color.red;
                    CorectValue();
                    Message();
                    lose = true;
                }
                FrameAnswearB.SetActive(true);
            }
        }

        private void OnClickC()
        {
            if (buttonsActive)
            {
                if (TestMilioneirs.CurrentAnswear == "C")
                {
                    FrameAnswearC.transform.GetComponent<Image>().color = Color.green;
                    SomeMethod();
                    Checkmilion();
                    timestart = DateTime.Now;
                }
                else
                {
                    FrameAnswearC.transform.GetComponent<Image>().color = Color.red;
                    CorectValue();
                    Message();
                    lose = true;
                }
                FrameAnswearC.SetActive(true);
            }
        }
        private void OnClickD()
        {
            if (buttonsActive)
            {
                if (TestMilioneirs.CurrentAnswear == "D")
                {
                    FrameAnswearD.transform.GetComponent<Image>().color = Color.green;
                    SomeMethod();
                    Checkmilion();
                    timestart = DateTime.Now;
                }
                else
                {
                    FrameAnswearD.transform.GetComponent<Image>().color = Color.red;
                    CorectValue();
                    Message();
                    lose = true;
                }
                FrameAnswearD.transform.GetComponent<Button>().CancelInvoke();
            }
        }
        private void CorectValue()
        {
            if (TestMilioneirs.CurrentAnswear == "A")
                FrameAnswearA.transform.GetComponent<Image>().color = Color.green;
            else if (TestMilioneirs.CurrentAnswear == "B")
                FrameAnswearB.transform.GetComponent<Image>().color = Color.green;
            else if (TestMilioneirs.CurrentAnswear == "C")
                FrameAnswearC.transform.GetComponent<Image>().color = Color.green;
            else if (TestMilioneirs.CurrentAnswear == "D")
                FrameAnswearD.transform.GetComponent<Image>().color = Color.green;
        }

        private void SomeMethod()
        {
            StartCoroutine(SomeCoroutine());
        }

        public bool flag = true;
        private IEnumerator SomeCoroutine()
        {
            if (flag)
            {
                TestMilioneirs.CurrentPosition++;
                flag = false;
                Next2();
            }

            buttonsActive = false;

            //yield return new WaitForSeconds(3);
            yield return new WaitForSeconds(3);
            TestMilioneirs.NextQuestion();

            flag = true;

            FrameAnswearA.transform.GetComponent<Image>().color = new Color(0.1059f, 0.2863f, 0.8196f);
            FrameAnswearB.transform.GetComponent<Image>().color = new Color(0.1059f, 0.2863f, 0.8196f);
            FrameAnswearC.transform.GetComponent<Image>().color = new Color(0.1059f, 0.2863f, 0.8196f);
            FrameAnswearD.transform.GetComponent<Image>().color = new Color(0.1059f, 0.2863f, 0.8196f);

            buttonsActive = true;
        }

        private void Message()
        {
            FrameLose2.SetActive(true);
            Value.text = TestMilioneirs.guaranteedWIN.ToString();
            timeif = false;
            DisableButtons();
        }

        private void MessageWin()
        {
            FrameLose2.SetActive(true);
            Value.text = TestMilioneirs.potentialWIN.ToString();
            timeif = false;
            DisableButtons();

        }
        private void Message50()
        {
            answears.Remove(corect);
            answear = (string)answears[random2];
            Debug.Log("onclic" + (string)answears[0] + " " + (string)answears[1]);

            if ((string)answears[0] == "A" || (string)answears[1] == "A")
            {
                TestMilioneirs.CurrentAnswearA = "";
            }
            if ((string)answears[0] == "B" || (string)answears[1] == "B")
            {
                TestMilioneirs.CurrentAnswearB = "";
            }
            if ((string)answears[0] == "C" || (string)answears[1] == "C")
            {
                TestMilioneirs.CurrentAnswearC = "";
            }
            if ((string)answears[0] == "D" || (string)answears[1] == "D")
            {
                TestMilioneirs.CurrentAnswearD = "";
            }

            Button50.SetActive(false);
            f2 = false;
        }
        private void Checkmilion()
        {
            if (TestMilioneirs.CurrentPosition >= 13)
            {
                FrameLose2.SetActive(true);
                Value.text = 1000000.ToString();
                timeif = false;
            }
        }

        private void Next()
        {
            Question.text = q;
            AnswearA.text = qa;
            AnswearB.text = qb;
            AnswearC.text = qc;
            AnswearD.text = qd;

            iftext = !iftext;

            text.text = Nick + text1;
        }

        private static void Next2()
        {
            iftext = !iftext;
        }

        private void DisableButtons()
        {   
            buttonsActive = false;
        }
    }
}
