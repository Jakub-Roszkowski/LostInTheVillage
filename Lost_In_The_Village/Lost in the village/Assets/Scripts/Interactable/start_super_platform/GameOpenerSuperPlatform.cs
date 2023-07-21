using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOpenerSuperPlatform : MonoBehaviour
{
    public static bool inGame = false;
    public static bool finishGame = false;
    public GameObject objToDestroy;
    private InteractableGameToIN interactableGameToIN;

    public TextMeshProUGUI promptText;

    void Start()
    {
        interactableGameToIN = GetComponent<InteractableGameToIN>();
        inGame = false;
        finishGame = false;
    }


    void Update()
    {
        if (finishGame)
        {
            removeObj();
            setText();
            finishGame = false;
        }


    }

    public void startGame()
    {
        inGame = true;
        SceneManager.LoadScene("SuperPlatform");

    }
    public void removeObj()
    {

        if (objToDestroy != null)
        {
            Destroy(objToDestroy);
        }
        interactableGameToIN.to_see = false;

    }

    private void setText()
    {

        switch (Language.language)
        {
            case Language_enum.Polish:
                promptText.text = "znajdü Roszkola";
                break;
            case Language_enum.English:
                promptText.text = "Find Roszkol";
                break;
            case Language_enum.German:
                promptText.text = "Finde Roszkol";
                break;
            case Language_enum.Spain:
                promptText.text = "Encuentra Roszkol";
                break;
        }
    }
}
