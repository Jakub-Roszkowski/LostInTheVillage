using LostInTheVillage.Helpers.Translations;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace LostInTheVillage.MiniGames.Games.SuperPlatform.Scripts
{
    public class EndPanel : MonoBehaviour
    {
        [SerializeField] private GameObject Panel;
        [SerializeField] private TMP_Text Score_TMP;

        private string gameRezult = "";

        private Image img;

        private string text1;
        private string text2;
        private string text3;
        private string text4;
        private string text5;
        private string text6;

        private string resultText;

        private void Start()
        {
            Panel.SetActive(false);
            img = Panel.GetComponent<Image>();

            (text1, text2, text3, text4, text5, text6) = LanguagesTranslation.SetTextSuperPlatformEnd();
        }

        private void Update()
        {
            if (PlayerPlatformController.IsWin)
            {
                gameRezult = text1;
                img.color = Color.green;
            }
            else
            {
                gameRezult = text2;
                img.color = Color.red;
            }

            resultText = $"{gameRezult} \n \n {text3} {PlayerPlatformController.Timeres}\n{text4} {PlayerPlatformController.Score}\n \n {text5}\n \n {text6}";
            Score_TMP.text = resultText;
        }
    }
}
