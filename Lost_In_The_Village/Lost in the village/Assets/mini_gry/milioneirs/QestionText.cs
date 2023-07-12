using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

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

    public static string nick;
    public static bool lose=false;
    public static bool timeif=false;
    public static bool f2=true;
    public static bool buttonsActive=true;


    string q;
    string qa;
    string qb;
    string qc;
    string qd;

    System.DateTime time;
    public static System.DateTime timestart;

    // Start is called before the first frame update
    void Start()
    {
        buttonsActive = true;
        f2 = true;
        bool iftext = false;
        timeif = false;
        timestart = DateTime.Now;

        System.Random rnd = new System.Random();
        random2 = rnd.Next(3);

        answears.Add("A");
        answears.Add("B");
        answears.Add("C");
        answears.Add("D");




        FrameLose2.SetActive(false);
        text.text = nick + " Wygra³eœ:";
        Value.text = test_milioneirs.guaranteedWIN.ToString();

        lose = false;

        Question.text = test_milioneirs.CurrentQuestion;
        AnswearA.text = test_milioneirs.CurrentAnswearA;
        AnswearB.text = test_milioneirs.CurrentAnswearB;
        AnswearC.text = test_milioneirs.CurrentAnswearC;
        AnswearD.text = test_milioneirs.CurrentAnswearD;

        FrameAnswearA.transform.GetComponent<Button>().onClick.AddListener(onClickA);
        FrameAnswearB.transform.GetComponent<Button>().onClick.AddListener(onClickB);
        FrameAnswearC.transform.GetComponent<Button>().onClick.AddListener(onClickC);
        FrameAnswearD.transform.GetComponent<Button>().onClick.AddListener(onClickD);
        ButtonFinish.transform.GetComponent<Button>().onClick.AddListener(MessageWin);
        Button50.transform.GetComponent<Button>().onClick.AddListener(Message50);
    }

    // Update is called once per frame
    void Update()
    {

        corect = test_milioneirs.CurrentAnswear;

        time = DateTime.Now;


        //answears.Remove(answear);

        /*

        Question.text = test.CurrentQuestion;
        AnswearA.text = test.CurrentAnswearA;
        AnswearB.text = test.CurrentAnswearB;
        AnswearC.text = test.CurrentAnswearC;
        AnswearD.text = test.CurrentAnswearD;

        FrameAnswearA.transform.GetComponent<Button>().onClick.AddListener(onClickA);
        FrameAnswearB.transform.GetComponent<Button>().onClick.AddListener(onClickB);
        FrameAnswearC.transform.GetComponent<Button>().onClick.AddListener(onClickC);
        FrameAnswearD.transform.GetComponent<Button>().onClick.AddListener(onClickD);
        ButtonFinish.transform.GetComponent<Button>().onClick.AddListener(MessageWin);
        Button50.transform.GetComponent<Button>().onClick.AddListener(Message50);

        */

        if (f2) { 
            if (Input.GetKeyDown(KeyCode.F2))
            {
                Message50();
            }
        }

        if (Input.GetKeyDown(KeyCode.F4))
        {
            MessageWin();
        }


        //int cur = test.CurrentPosition;
        //text.text = nick + " Wygra³eœ:";

        
        if (timeif)
        {
            if (timestart.AddSeconds(15) < time) {
                corectValue();
                Message();
                lose = true;
            }
            if((timestart.AddSeconds(15) - time)>=TimeSpan.Zero)
            {
                timeShow.text = (timestart.AddSeconds(15) - time).Seconds.ToString();
            }
            else
            {
                timeShow.text = "";
            }
            
        }
        

        q = test_milioneirs.CurrentQuestion;
        qa = test_milioneirs.CurrentAnswearA;
        qb = test_milioneirs.CurrentAnswearB;
        qc = test_milioneirs.CurrentAnswearC;
        qd = test_milioneirs.CurrentAnswearD;

        if (text){ next(); }



    }




    void onClickA()
    {
        if (buttonsActive)
        {
            if (test_milioneirs.CurrentAnswear == "A")
            {
                FrameAnswearA.transform.GetComponent<Image>().color = Color.green;
                SomeMethod();
                checkmilion();

                timestart = DateTime.Now;


            }

            else
            {
                FrameAnswearA.transform.GetComponent<Image>().color = Color.red;
                corectValue();
                Message();
                lose = true;
            }
            FrameAnswearA.SetActive(true);
        }
    }


    void onClickB()
    {
        if (buttonsActive)
        {
            if (test_milioneirs.CurrentAnswear == "B")
            {
                FrameAnswearB.transform.GetComponent<Image>().color = Color.green;
                SomeMethod();
                checkmilion();
                timestart = DateTime.Now;

            }

            else
            {
                FrameAnswearB.transform.GetComponent<Image>().color = Color.red;
                corectValue();
                Message();
                lose = true;
            }
            FrameAnswearB.SetActive(true);
        }

    }

    void onClickC()
    {
        if (buttonsActive)
        {
            if (test_milioneirs.CurrentAnswear == "C")
            {
                FrameAnswearC.transform.GetComponent<Image>().color = Color.green;
                SomeMethod();
                checkmilion();
                timestart = DateTime.Now;

            }

            else
            {
                FrameAnswearC.transform.GetComponent<Image>().color = Color.red;
                corectValue();
                Message();
                lose = true;
            }
            FrameAnswearC.SetActive(true);
        }

    }
    void onClickD()
    {
        if (buttonsActive)
        {
            if (test_milioneirs.CurrentAnswear == "D")
            {
                FrameAnswearD.transform.GetComponent<Image>().color = Color.green;
                SomeMethod();
                checkmilion();
                timestart = DateTime.Now;

            }

            else
            {
                FrameAnswearD.transform.GetComponent<Image>().color = Color.red;
                corectValue();
                Message();
                lose = true;
            }
            FrameAnswearD.transform.GetComponent<Button>().CancelInvoke();
        }

    }

    void corectValue()
    {
        if (test_milioneirs.CurrentAnswear == "A")
            FrameAnswearA.transform.GetComponent<Image>().color = Color.green;
        else if (test_milioneirs.CurrentAnswear == "B")
            FrameAnswearB.transform.GetComponent<Image>().color = Color.green;
        else if (test_milioneirs.CurrentAnswear == "C")
            FrameAnswearC.transform.GetComponent<Image>().color = Color.green;
        else if (test_milioneirs.CurrentAnswear == "D")
            FrameAnswearD.transform.GetComponent<Image>().color = Color.green;
    }

    public void SomeMethod()
    {
        StartCoroutine(SomeCoroutine());
    }

    public bool flag = true;
    private IEnumerator SomeCoroutine()
    {
        if (flag)
        {
            test_milioneirs.CurrentPosition++;
            flag = false;
            next2();
        }

        buttonsActive = false;

        //yield return new WaitForSeconds(3);
        yield return new WaitForSeconds(3);
        test_milioneirs.NextQuestion();
        
        flag = true;

        FrameAnswearA.transform.GetComponent<Image>().color = new Color(0.1059f, 0.2863f, 0.8196f);
        FrameAnswearB.transform.GetComponent<Image>().color = new Color(0.1059f, 0.2863f, 0.8196f);
        FrameAnswearC.transform.GetComponent<Image>().color = new Color(0.1059f, 0.2863f, 0.8196f);
        FrameAnswearD.transform.GetComponent<Image>().color = new Color(0.1059f, 0.2863f, 0.8196f);

        buttonsActive = true;
        

    }

    void Message()
    {
        FrameLose2.SetActive(true);
        Value.text = test_milioneirs.guaranteedWIN.ToString();
        timeif = false;
        disableButtons();
    }

    void MessageWin()
    {
        FrameLose2.SetActive(true);
        Value.text = test_milioneirs.potentialWIN.ToString();
        timeif = false;
        disableButtons();

    } 
    void Message50()
    {
        answears.Remove(corect);
        answear = (string)answears[random2];
        //answears.Remove(answear);
        Debug.Log("onclic" + (string)answears[0] + " " + (string)answears[1]);


        if ((string)answears[0] == "A" || (string)answears[1] == "A")
        {
            test_milioneirs.CurrentAnswearA = "";
        }
        if ((string)answears[0] == "B" || (string)answears[1] == "B")
        {
            test_milioneirs.CurrentAnswearB = "";
        }
        if ((string)answears[0] == "C" || (string)answears[1] == "C")
        {
            test_milioneirs.CurrentAnswearC = "";
        }
        if ((string)answears[0] == "D" || (string)answears[1] == "D")
        {
            test_milioneirs.CurrentAnswearD = "";
        }


        Button50.SetActive(false);
        f2 = false;
    }





    void checkmilion()
    {
        
        if (test_milioneirs.CurrentPosition >= 13)
        {
            FrameLose2.SetActive(true);
            Value.text = 1000000.ToString();
            timeif = false;
        }
    }

    void next()
    {


        Question.text = q;
        AnswearA.text = qa;
        AnswearB.text = qb;
        AnswearC.text = qc;
        AnswearD.text = qd;


        iftext = !iftext;

        text.text = nick + " Wygra³eœ:";
    }

    public static void next2()
    {
        iftext = !iftext;
    }


    void disableButtons()
    {
        buttonsActive = false;
    }
}
