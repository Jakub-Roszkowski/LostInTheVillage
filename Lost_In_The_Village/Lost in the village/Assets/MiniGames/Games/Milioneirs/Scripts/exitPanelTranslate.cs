using LostInTheVillage.Helpers.Translations;
using TMPro;
using UnityEngine;

namespace LostInTheVillage.MiniGames.Games.Milioneirs.Scripts
{
    public class ExitPanelTranslate : MonoBehaviour
    {
        [SerializeField] private TMP_Text text;

        private void Start()
        {
            text.text = LanguagesTranslation.SetTextExitPanel();
        }
    }
}
