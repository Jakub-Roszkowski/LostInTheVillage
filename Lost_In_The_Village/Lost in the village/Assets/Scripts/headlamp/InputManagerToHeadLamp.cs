using UnityEngine;

namespace LostInTheVillage.Headlamp
{
    public class InputManagerToHeadLamp : MonoBehaviour
    {
        private PlayerInput playerInput;
        public PlayerInput.OnFootActions OnFoot { get; private set; }

        private void Awake()
        {
            playerInput = new PlayerInput();
            OnFoot = playerInput.OnFoot;
        }

        private void OnEnable()
        {
            OnFoot.Enable();
        }

        private void OnDisable()
        {
            OnFoot.Disable();
        }
    }
}
