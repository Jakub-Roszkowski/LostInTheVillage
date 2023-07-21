using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOpenerPuzzle : MonoBehaviour
{
    public static bool inGame = false;
    public static bool finishGame = false;

    public TextMeshProUGUI destinationText;
    public CharacterMessage Orzel;

    public GameObject bosses;

    void Start()
    {
        inGame = false;
        finishGame = false;
    }


    void Update()
    {
        if (finishGame)
        {
            Orzel.place = Place_enum.Orzel_tunel;
            setText();
            bosses.SetActive(true);
            Time.timeScale = 1f;
            finishGame = false;
            InteractableLaptop.toSee = true;
        }


    }

    public void startGame()
    {
        inGame = true;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("puzzle");

    }

    private void setText()
    {

        switch (Language.language)
        {
            case Language_enum.Polish:
                destinationText.text = "Orze³";
                break;
            case Language_enum.English:
                destinationText.text = "Eagle";
                break;
            case Language_enum.German:
                destinationText.text = "Adler";
                break;
            case Language_enum.Spain:
                destinationText.text = "Águila";
                break;
        }
    }
}
