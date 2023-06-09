using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadSceneOnTrigger : MonoBehaviour
{
    public string sceneName = "Village2"; // Nazwa docelowej sceny, kt�r� chcesz za�adowa�
    public TextMeshProUGUI promptText;
    public bool ifistoOpen = false;
    public Slider loadingSlider;
    public GameObject objectToActivate;
    public GameObject[] objectsToDeactivate;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Sprawdzamy, czy obiekt, kt�ry wszed� w obszar kolizji, ma tag "Player". Mo�esz dostosowa� ten warunek do swoich potrzeb.
        {
            if (ifistoOpen)
            {
                StartCoroutine(LoadSceneAsync()); // �adujemy docelow� scen� na podstawie jej nazwy
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
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(sceneName); // Rozpocz�cie asynchronicznego �adowania nowej sceny
        asyncOperation.allowSceneActivation = false; // Ustawienie na false, aby nowa scena nie zosta�a automatycznie aktywowana po za�adowaniu

        while (!asyncOperation.isDone)
        {
            float progress = Mathf.Clamp01(asyncOperation.progress);
            loadingSlider.value = progress;

            if (asyncOperation.progress >= 0.9f)
            {
                asyncOperation.allowSceneActivation = true; // Je�li post�p �adowania osi�gnie 90%, mo�na zezwoli� na automatyczn� aktywacj� nowej sceny
            }

            yield return null;
        }

        // Mo�esz tutaj wykona� dodatkowe operacje po zako�czeniu �adowania nowej sceny
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





