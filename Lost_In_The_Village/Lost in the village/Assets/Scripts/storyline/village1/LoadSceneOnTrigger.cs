using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadSceneOnTrigger : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI promptText;
    [SerializeField] private Slider loadingSlider;
    [SerializeField] private GameObject objectToActivate;
    [SerializeField] private GameObject[] objectsToDeactivate;

    public static bool ifistoOpen = false;

    private string sceneName = Helpers.Scenes.Village2;

    void Start()
    {
        ifistoOpen = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (ifistoOpen)
            {
                StartCoroutine(LoadSceneAsync());
            }
            else
            {
                DisplayPromptText();
            }
        }
    }

    private void DisplayPromptText()
    {
        promptText.text = Helpers.Languages.SetTextNotAvailable();

        StartCoroutine(ClearPromptText(3f));
    }

    private System.Collections.IEnumerator ClearPromptText(float delay)
    {
        yield return new WaitForSeconds(delay);

        promptText.text = string.Empty;
    }

    private IEnumerator LoadSceneAsync()
    {
        ActivateObjects();
        loadingSlider.value = 0f;
        yield return new WaitForSeconds(4f);
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(sceneName);
        asyncOperation.allowSceneActivation = false;

        while (!asyncOperation.isDone)
        {
            float progress = Mathf.Clamp01(asyncOperation.progress);
            loadingSlider.value = progress;

            if (asyncOperation.progress >= 0.9f)
            {
                asyncOperation.allowSceneActivation = true;
            }
            yield return null;
        }
    }

    private void ActivateObjects()
    {
        if (objectToActivate != null)
        {
            objectToActivate.SetActive(true);
        }

        foreach (var obj in objectsToDeactivate)
        {
            if (obj != null)
            {
                obj.SetActive(false);
            }
        }
    }
}