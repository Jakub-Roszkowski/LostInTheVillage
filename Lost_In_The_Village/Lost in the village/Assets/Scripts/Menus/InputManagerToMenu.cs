using UnityEngine;

namespace LostInTheVillage.Menus
{
    public class InputManagerToMenu : MonoBehaviour
    {
        public PlayerInput.OnFootActions OnFoot { get; private set; }

        private PlayerInput playerInput;

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
