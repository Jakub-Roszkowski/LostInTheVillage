using UnityEngine;

namespace LostInTheVillage.Player
{
    public class InputManager : MonoBehaviour
    {        
        public PlayerInput.OnFootActions OnFoot { get; private set; }

        private PlayerInput playerInput;
        private PlayerMotor motor;
        private PlayerLook look;

        private bool isRunning = false;

        private void Awake()
        {
            playerInput = new PlayerInput();
            OnFoot = playerInput.OnFoot;

            motor = GetComponent<PlayerMotor>();
            look = GetComponent<PlayerLook>();

            OnFoot.Jump.performed += ctx => motor.Jump();

            OnFoot.Run.performed += ctx => SetRunning(true);
            OnFoot.Run.canceled += ctx => SetRunning(false);
        }

        private void Update()
        {
            motor.ProcessMove(OnFoot.Movement.ReadValue<Vector2>(), isRunning);
        }

        private void LateUpdate()
        {
            look.ProcessLook(OnFoot.Look.ReadValue<Vector2>());
        }

        private void OnEnable()
        {
            OnFoot.Enable();
        }

        private void OnDisable()
        {
            OnFoot.Disable();
        }

        private void SetRunning(bool isRunning)
        {
            this.isRunning = isRunning;
        }
    }
}