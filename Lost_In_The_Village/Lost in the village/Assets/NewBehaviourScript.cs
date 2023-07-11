using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public string sceneName = "puzzle";
    public GameObject objectToActivate;
    public GameObject[] objectsToDeactivate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(LoadSceneAsync());
            //ActivateObjects();
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }

    private IEnumerator LoadSceneAsync()
    {
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(sceneName);
        asyncOperation.allowSceneActivation = false;

        while (!asyncOperation.isDone)
        {
            float progress = Mathf.Clamp01(asyncOperation.progress);


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
                Destroy(obj);
            }
        }
    }
}
