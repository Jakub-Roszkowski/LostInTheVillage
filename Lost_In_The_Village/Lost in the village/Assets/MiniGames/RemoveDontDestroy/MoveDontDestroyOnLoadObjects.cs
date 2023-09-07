using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class MoveDontDestroyOnLoadObjects : MonoBehaviour
{
    public static GameObject[] dontDestroyObjects;

    private void Start()
    {
        dontDestroyObjects = GameObject.FindGameObjectsWithTag("DontDestroyOnLoad");

        foreach (GameObject obj in dontDestroyObjects)
        {
            // Wy³¹cz sam obiekt
            obj.SetActive(false);
        }
    }



}

