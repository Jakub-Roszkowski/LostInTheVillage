using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class FiendTelephone : MonoBehaviour
{
    public TMP_Text AnswearText;
    public GameObject Button;
    public GameObject FriendTelephone;

    //int random = 0;
    //int random2 = 0;
    string answear;


    ArrayList answears = new ArrayList();

    public static bool f1 = true;





    // Start is called before the first frame update
    void Start()
    {
        FriendTelephone.SetActive(false);

        System.Random rnd = new System.Random();
        //random = rnd.Next(100);
        //random2 = rnd.Next(1);

        answears.Add("A");
        answears.Add("B");
        answears.Add("C");
        answears.Add("D");

        f1 = true;

}

    // Update is called once per frame
    void Update()
    {



        string corect = test_milioneirs.CurrentAnswear;
        answear = corect;



        //answears.Remove(corect);

        //if (random <= 80) answear = corect;
        //else
        //{
        //    answear = (string)answears[random2];
        //}


        AnswearText.text = "Drogi przyjacielu moim skromnym zdaniem poprawna odpowiedŸ to: " + answear;

        Button.transform.GetComponent<Button>().onClick.AddListener(onClickButton);
        if (Input.GetKey(KeyCode.Escape))
        {
            FriendTelephone.SetActive(false);
        }

        if (f1)
        {
            if (Input.GetKeyDown(KeyCode.F1))
            {
                onClickButton();
            }
        }
    }

    void onClickButton()
    {
        FriendTelephone.SetActive(true);
        Button.SetActive(false);
        f1 = false;
    }
}
