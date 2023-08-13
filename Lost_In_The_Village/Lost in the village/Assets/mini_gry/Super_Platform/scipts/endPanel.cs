using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class endPanel : MonoBehaviour
{
    public GameObject Panel;
    public TMP_Text Score_TMP;
    public TMP_Text ifWin;
    private Image img;
    private string rezifwin = "";

    private string text1;
    private string text2;
    private string text3;
    private string text4;
    private string text5;
    private string text6;

    private string result;
    void Start()
    {
        Panel.SetActive(false);
        img = Panel.GetComponent<Image>();

        (text1, text2, text3, text4, text5, text6) = Helpers.Languages.SetTextSuperPlatformEnd();
    }

    void Update()
    {
        if (PlayerPlatform.win)
        {
            rezifwin = text1;
            img.color = UnityEngine.Color.green;
        }
        else
        {
            rezifwin = text2;
            img.color = UnityEngine.Color.red;
        }

        result = $"{rezifwin} \n \n {text3}: {PlayerPlatform.timeres}\n{text4} {PlayerPlatform.score}\n \n {text5}\n \n {text6}";
        Score_TMP.text = result;
    }
}
