using TMPro;
using UnityEngine;

namespace LostInTheVillage.MiniGames.Games.Milioneirs.Scripts
{
    public class ExitPanelTranslate : MonoBehaviour
    {
        public TMP_Text text;

        private void Start()
        {
            text.text = Helpers.Languages.SetTextExitPanel();
        }
    }
}
