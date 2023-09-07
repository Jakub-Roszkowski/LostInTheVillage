using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class FriendTelephone : MonoBehaviour
{
    public TMP_Text AnswearText;
    public GameObject Button;
    public GameObject TelephonePanel;

    ArrayList answears = new ArrayList();
    private string text;
    public static bool f1 = true;
    void Start()
    {
        TelephonePanel.SetActive(false);

        System.Random rnd = new System.Random();

        answears.Add("A");
        answears.Add("B");
        answears.Add("C");
        answears.Add("D");

        f1 = true;

        text = Helpers.Languages.SetTextFriendTelephone();
    }

    void Update()
    {
        AnswearText.text = text + test_milioneirs.CurrentAnswear;

        Button.transform.GetComponent<Button>().onClick.AddListener(onClickButton);
        if (Input.GetKey(KeyCode.Escape))
        {
            TelephonePanel.SetActive(false);
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
        TelephonePanel.SetActive(true);
        Button.SetActive(false);
        f1 = false;
    }
}
