using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadSceneOnTrigger : MonoBehaviour
{
    public string sceneName = "Village2"; // Nazwa docelowej sceny, któr¹ chcesz za³adowaæ
    public TextMeshProUGUI promptText;
    public bool ifistoOpen = false;
    public Slider loadingSlider;
    public GameObject objectToActivate;
    public GameObject[] objectsToDeactivate;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Sprawdzamy, czy obiekt, który wszed³ w obszar kolizji, ma tag "Player". Mo¿esz dostosowaæ ten warunek do swoich potrzeb.
        {
            if (ifistoOpen)
            {
                StartCoroutine(LoadSceneAsync()); // £adujemy docelow¹ scenê na podstawie jej nazwy
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
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(sceneName); // Rozpoczêcie asynchronicznego ³adowania nowej sceny
        asyncOperation.allowSceneActivation = false; // Ustawienie na false, aby nowa scena nie zosta³a automatycznie aktywowana po za³adowaniu

        while (!asyncOperation.isDone)
        {
            float progress = Mathf.Clamp01(asyncOperation.progress);
            loadingSlider.value = progress;

            if (asyncOperation.progress >= 0.9f)
            {
                asyncOperation.allowSceneActivation = true; // Jeœli postêp ³adowania osi¹gnie 90%, mo¿na zezwoliæ na automatyczn¹ aktywacjê nowej sceny
            }

            yield return null;
        }

        // Mo¿esz tutaj wykonaæ dodatkowe operacje po zakoñczeniu ³adowania nowej sceny
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





