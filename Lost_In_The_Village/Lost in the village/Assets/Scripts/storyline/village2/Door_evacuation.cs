using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Door_evacuation : MonoBehaviour
{
    public GameObject objectToActivate;
    public GameObject[] objectsToDeactivate;
    public TextMeshProUGUI promptText;
    public bool ifistoOpen = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (ifistoOpen)
            {
                ActivateObjects();
            }
            else
            {
                DisplayPromptText();
            }
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

    private void DisplayPromptText()
    {
        promptText.text = "JSOS jeszcze nie dzia³a";

        StartCoroutine(ClearPromptText(3f));
    }

    private System.Collections.IEnumerator ClearPromptText(float delay)
    {
        yield return new WaitForSeconds(delay);

        promptText.text = string.Empty;
    }
}
