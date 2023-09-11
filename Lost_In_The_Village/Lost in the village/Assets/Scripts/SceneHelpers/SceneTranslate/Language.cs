using LostInTheVillage.Helpers;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace LostInTheVillage.SceneHelpers.SceneTranslate
{
    public class Language : MonoBehaviour
    {
        public static LanguageEnum LanguageName = LanguageEnum.Polish;
        private string sceneName = Scenes.Village1;
        AsyncOperation asyncOperation;
        private void Start()
        {
            asyncOperation = SceneManager.LoadSceneAsync(sceneName);
            asyncOperation.allowSceneActivation = false;
        }
        public void Polish()
        {
            LanguageName = LanguageEnum.Polish;
            asyncOperation.allowSceneActivation = true;
        }
        public void Enlish()
        {
            LanguageName = LanguageEnum.English;
            asyncOperation.allowSceneActivation = true;
        }
        public void German()
        {
            LanguageName = LanguageEnum.German;
            asyncOperation.allowSceneActivation = true;
        }
        public void Spanish()
        {
            LanguageName = LanguageEnum.Spanish;
            asyncOperation.allowSceneActivation = true;
        }
    }
}
