using UnityEngine;
using UnityEngine.SceneManagement;
public class Language : MonoBehaviour
{
    public static Language_enum language = Language_enum.Polish;
    public string sceneName = Helpers.Scenes.Village1;
    AsyncOperation asyncOperation;
    public void Start()
    {
        asyncOperation = SceneManager.LoadSceneAsync(sceneName);
        asyncOperation.allowSceneActivation = false;
    }
    public void polish()
    {
        language = Language_enum.Polish;
        asyncOperation.allowSceneActivation = true;
    }
    public void enlish()
    {
        language = Language_enum.English;
        asyncOperation.allowSceneActivation = true;
    }
    public void german()
    {
        language = Language_enum.German;
        asyncOperation.allowSceneActivation = true;
    }
    public void spanish()
    {
        language = Language_enum.Spain;
        asyncOperation.allowSceneActivation = true;
    }
}
