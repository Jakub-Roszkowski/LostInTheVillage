using LostInTheVillage.Helpers.Translations;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace LostInTheVillage.MiniGames.Games.Milioneirs.Scripts.Lifebuoys
{
    public class PublicAnswear : MonoBehaviour
    {
        [SerializeField] private TMP_Text AnswearText;
        [SerializeField] private GameObject Button;
        [SerializeField] private GameObject PublicPanel;

        private static bool f3 = true;

        private int randomMax = 100;
        private int random = 0;
        private int random2 = 0;
        private int random3 = 0;

        private string corect;
        private string text;

        private void Start()
        {
            f3 = true;
            PublicPanel.SetActive(false);

            randomMax = 100;
            System.Random rnd = new System.Random();
            random = rnd.Next(50, randomMax);
            randomMax = randomMax - random;
            random2 = rnd.Next(randomMax);
            randomMax = randomMax - random2;
            random3 = rnd.Next(randomMax);
            randomMax = randomMax - random3;

            text = LanguagesTranslation.SetTextPublicAnswear();
        }

        private void Update()
        {
            corect = MilioneirsQuestions.CurrentAnswer;

            Button.transform.GetComponent<Button>().onClick.AddListener(OnClickButton);
            if (Input.GetKey(KeyCode.Escape))
            {
                PublicPanel.SetActive(false);
            }

            if (f3)
            {
                if (Input.GetKeyDown(KeyCode.F3))
                {
                    OnClickButton();
                }
            }
        }

        private void OnClickButton()
        {
            PublicPanel.SetActive(true);
            Button.SetActive(false);

            int valueA = 0;
            int valueB = 0;
            int valueC = 0;
            int valueD = 0;

            switch (corect)
            {
                case "A":
                    valueA = random;
                    valueB = random2;
                    valueC = random3;
                    valueD = randomMax;
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

            AnswearText.text = text + "\n" + "A:" + valueA.ToString() + "%" + "\n" + "B:" + valueB.ToString() + "%" + "\n" + "C:" + valueC.ToString() + "%" + "\n" + "D:" + valueD.ToString() + "%";

            f3 = false;
        }
    }
}
