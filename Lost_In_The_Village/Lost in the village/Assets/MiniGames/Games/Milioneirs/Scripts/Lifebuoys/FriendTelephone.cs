using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using LostInTheVillage.Helpers;

namespace LostInTheVillage.MiniGames.Games.Milioneirs.Scripts.Lifebuoys
{
    public class FriendTelephone : MonoBehaviour
    {
        [SerializeField] private TMP_Text answearText;
        [SerializeField] private GameObject button;
        [SerializeField] private GameObject telephonePanel;

        private static bool f1 = true;
        private ArrayList answears = new ArrayList();
        private string text;

        private void Start()
        {
            telephonePanel.SetActive(false);

            System.Random rnd = new System.Random();

            answears.Add("A");
            answears.Add("B");
            answears.Add("C");
            answears.Add("D");

            f1 = true;

            text = Languages.SetTextFriendTelephone();
        }

        private void Update()
        {
            answearText.text = text + TestMilioneirs.CurrentAnswear;

            button.transform.GetComponent<Button>().onClick.AddListener(OnClickButton);
            if (Input.GetKey(KeyCode.Escape))
            {
                telephonePanel.SetActive(false);
            }

            if (f1)
            {
                if (Input.GetKeyDown(KeyCode.F1))
                {
                    OnClickButton();
                }
            }
        }

        private void OnClickButton()
        {
            telephonePanel.SetActive(true);
            button.SetActive(false);
            f1 = false;
        }
    }
}
