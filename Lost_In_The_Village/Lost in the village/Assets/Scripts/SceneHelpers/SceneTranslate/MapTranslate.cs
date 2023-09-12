using LostInTheVillage.Helpers.Translations;
using UnityEngine;

namespace LostInTheVillage.SceneHelpers.SceneTranslate
{
    public class MapTranslate : MonoBehaviour
    {
        [SerializeField] private GameObject map1;
        [SerializeField] private GameObject map2;
        [SerializeField] private GameObject map3;
        [SerializeField] private GameObject map4;

        private void Start()
        {
            switch (Language.LanguageName)
            {
                case LanguageEnum.Polish:
                    map1.SetActive(true);
                    break;
                case LanguageEnum.English:
                    map2.SetActive(true);
                    break;
                case LanguageEnum.German:
                    map3.SetActive(true);
                    break;
                case LanguageEnum.Spanish:
                    map4.SetActive(true);
                    break;
            }
        }
    }
}
