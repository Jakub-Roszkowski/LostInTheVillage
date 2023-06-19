using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadSceneOnTrigger : MonoBehaviour
{
    public string sceneName = "Village2"; // The name of the target scene you want to load
    public TextMeshProUGUI promptText;
    public bool ifistoOpen = false;
    public Slider loadingSlider;
    public GameObject objectToActivate;
    public GameObject[] objectsToDeactivate;

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
        promptText.text = "Nie posiadasz klucza";

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





