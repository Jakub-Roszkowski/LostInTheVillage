using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOpenerPuzzle : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI destinationText;
    [SerializeField] private CharacterMessage Orzel;
    [SerializeField] private GameObject bosses;

    public static bool inGame = false;
    public static bool finishGame = false;

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
            LaptopInteractable.toSee = true;
        }
    }

    public void startGame()
    {
        inGame = true;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene(Helpers.Scenes.Puzzle);
    }

    private void setText()
    {
        destinationText.text = Helpers.Languages.SetTextEagle();
    }
}
