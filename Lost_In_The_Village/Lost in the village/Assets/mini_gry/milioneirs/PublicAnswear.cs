using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PublicAnswear : MonoBehaviour
{

    public TMP_Text AnswearText;
    public GameObject Button;
    public GameObject PublicPanel;

    int randomMax = 100;
    int random = 0;
    int random2 = 0;
    int random3 = 0;
    int answearA;
    int answearB;
    int answearC;
    int answearD;

    string corect;


    public static bool f3 = true;

    private string text;


    ArrayList answears = new ArrayList();
    // Start is called before the first frame update
    void Start()
    {

        f3 = true;
        PublicPanel.SetActive(false);

        randomMax = 100;
        System.Random rnd = new System.Random();
        random = rnd.Next(50,randomMax);
        randomMax = randomMax - random;
        random2 = rnd.Next(randomMax);
        randomMax = randomMax - random2;
        random3 = rnd.Next(randomMax);
        randomMax = randomMax - random3;




        switch (Language.language)
        {
            case Language_enum.Polish:
                text = "Tak odpowiedzia�a publiczno��:";
                break;
            case Language_enum.English:
                text = "This is how the audience responded:";
                break;
            case Language_enum.German:
                text = "So hat das Publikum geantwortet:";
                break;
            case Language_enum.Spain:
                text = "As� respondi� la audiencia:";
                break;
        }

    }

    // Update is called once per frame
    void Update()
    {
        corect = test_milioneirs.CurrentAnswear;


        Button.transform.GetComponent<Button>().onClick.AddListener(onClickButton);
        if (Input.GetKey(KeyCode.Escape))
        {
            PublicPanel.SetActive(false);
        }

        if (f3)
        {
            if (Input.GetKeyDown(KeyCode.F3))
            {
                onClickButton();
            }
        }
    }

    void onClickButton()
    {

        PublicPanel.SetActive(true);
        Button.SetActive(false);

        int valueA=0;
        int valueB=0;
        int valueC=0;
        int valueD=0;

        switch (corect)
        {
            case "A":
                valueA=random;
                valueB=random2;
                valueC=random3;
                valueD=randomMax;
                break;
            case "B":
                valueA = random2;
                valueB = random;
                valueC = random3;
                valueD = randomMax;
                break;
            case "C":
                valueA = random3;
                valueB = random2;
                valueC = random;
                valueD = randomMax;
                break;
            case "D":
                valueA = randomMax;
                valueB = random2;
                valueC = random3;
                valueD = random;
                break;
        }

        AnswearText.text = text + "\n"+"A:"+valueA.ToString()+"%" + "\n" + "B:" + valueB.ToString() + "%" + "\n" + "C:" + valueC.ToString() + "%" + "\n" + "D:" + valueD.ToString() + "%";

        f3 = false;
    }
}
