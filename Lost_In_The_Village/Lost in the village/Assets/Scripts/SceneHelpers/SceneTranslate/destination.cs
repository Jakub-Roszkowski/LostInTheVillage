using TMPro;
using UnityEngine;

namespace LostInTheVillage.SceneHelpers.SceneTranslate
{
    public class Destination : MonoBehaviour
    {
        public TextMeshProUGUI promptText;

        private void Start()
        {
            promptText.text = Helpers.Languages.SetDestinationVillage2();
        }
    }
}
