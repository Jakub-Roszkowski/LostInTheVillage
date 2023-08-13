using UnityEngine;

public class InputManagerToMenu : MonoBehaviour
{
    public PlayerInput.OnFootActions onFoot;

    private PlayerInput playerInput;
    
    void Awake()
    {
        playerInput = new PlayerInput();
        onFoot = playerInput.OnFoot;
    }

    void Update()
    {

    }

    private void OnEnable()
    {
        onFoot.Enable();
    }

    private void OnDisable()
    {
        onFoot.Disable();
    }
}
