using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGameMenu : MonoBehaviour
{
    [SerializeField] private GameObject gamesPanel;
    [SerializeField] private GameObject[] objects_to_active;

    public PlayerInput.OnFootActions onFoot;
    public bool ingame = false;

    public static bool ingame2 = false;
    
    private PlayerInput playerInput;

    void Awake()
    {
        playerInput = new PlayerInput();
        onFoot = playerInput.OnFoot;
    }

    private void OnEnable()
    {
        onFoot.Enable();
    }

    private void OnDisable()
    {
        onFoot.Disable();
    }

    void Start()
    {

    }

    void Update()
    {
        if (onFoot.Exit.triggered)
        {
            Quit();
        }
        if (ingame)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        if (ingame2)
        {
            Time.timeScale = 0f;
        }
    }

    public void Quit()
    {
        ingame = false;
        ingame2 = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1f;
        gamesPanel.SetActive(false);
        foreach (GameObject elem in objects_to_active)
        {
            elem.SetActive(true);
        }
    }

    public void milioneirs()
    {
        ingame = true;
        ingame2 = false;
        SceneManager.LoadScene(Helpers.Scenes.Milioneirs);
        Time.timeScale = 1f;
    }

    public void puzzle()
    {
        ingame = true;
        ingame2 = false;
        SceneManager.LoadScene(Helpers.Scenes.Puzzle);
        Time.timeScale = 1f;
    }

    public void superPlatform()
    {
        ingame = true;
        ingame2 = false;
        SceneManager.LoadScene(Helpers.Scenes.SuperPlatform);
        Time.timeScale = 1f;
    }
}