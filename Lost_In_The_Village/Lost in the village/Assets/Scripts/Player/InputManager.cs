using UnityEngine;

public class InputManager : MonoBehaviour
{
    private PlayerInput playerInput;
    public PlayerInput.OnFootActions onFoot;

    private PlayerMotor motor;
    private PlayerLook look;

    private bool isRunning = false;

    void Awake()
    {
        playerInput = new PlayerInput();
        onFoot = playerInput.OnFoot;

        motor = GetComponent<PlayerMotor>();
        look = GetComponent<PlayerLook>();

        onFoot.Jump.performed += ctx => motor.Jump();

        onFoot.Run.performed += ctx => SetRunning(true);
        onFoot.Run.canceled += ctx => SetRunning(false);
    }

    void Update()
    {
        motor.ProcessMove(onFoot.Movement.ReadValue<Vector2>(), isRunning);
    }

    private void LateUpdate()
    {
        look.ProcessLook(onFoot.Look.ReadValue<Vector2>());
    }

    private void OnEnable()
    {
        onFoot.Enable();
    }

    private void OnDisable()
    {
        onFoot.Disable();
    }

    private void SetRunning(bool isRunning)
    {
        this.isRunning = isRunning;
    }
}