using LostInTheVillage.Helpers.Translations;
using TMPro;
using UnityEngine;

namespace LostInTheVillage.SceneHelpers.SceneTranslate
{
    public class Destination : MonoBehaviour
    {
        public TextMeshProUGUI promptText;

        private void Start()
        {
            promptText.text = LanguagesTranslation.SetDestinationVillage2();
        }
    }
}
