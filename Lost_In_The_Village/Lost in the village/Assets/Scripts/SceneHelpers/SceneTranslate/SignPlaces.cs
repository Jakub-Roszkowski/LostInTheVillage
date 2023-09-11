using LostInTheVillage.Helpers;
using TMPro;
using UnityEngine;

namespace LostInTheVillage.SceneHelpers.SceneTranslate
{
    public enum StreetName
    {
        DistantStreet,
        MainStreet,
        QuietStreet,
        DowntownStreet,
        GermanStreet,
        TentStreet,
        ParkStreet,
        ArchitectsStreet,
        ChineseStreet,
        VillageStreet,
        CowshedStreet,
    }

    public class SignPlaces : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI street1;
        [SerializeField] private TextMeshProUGUI street2;

        public StreetName streetname1;
        public StreetName streetname2;

        private void Start()
        {
            street1.text = SelectStreetNameText(streetname1);
            street2.text = SelectStreetNameText(streetname2);
        }

        private string SelectStreetNameText(StreetName street)
        {
            string text = "";
            text = SignTextTranslate.TranslateStreet(street);
            return text;
        }
    }
}
