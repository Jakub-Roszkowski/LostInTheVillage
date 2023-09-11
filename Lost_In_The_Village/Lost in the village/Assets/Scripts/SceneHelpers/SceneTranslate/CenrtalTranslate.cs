using TMPro;
using UnityEngine;

namespace LostInTheVillage.SceneHelpers.SceneTranslate
{
    public class CenrtalTranslate : MonoBehaviour
    {
        public TextMeshProUGUI Central;

        private void Start()
        {
            Central.text = Helpers.Languages.SetTextCentalBuild();
        }
    }
}