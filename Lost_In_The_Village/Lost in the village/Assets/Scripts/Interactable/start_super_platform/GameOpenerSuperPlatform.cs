using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOpenerSuperPlatform : MonoBehaviour
{
    [SerializeField] private GameObject objToDestroy;
    [SerializeField] private TextMeshProUGUI promptText;

    public static bool inGame = false;
    public static bool finishGame = false;

    private InteractableGameToIN interactableGameToIN;

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
        SceneManager.LoadScene(Helpers.Scenes.SuperPlatform);
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
        promptText.text = Helpers.Languages.SetTextFindRoszkol();
    }
}
