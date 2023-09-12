using UnityEngine;

namespace LostInTheVillage.Storyline.Village2
{
    public class InputManagerToExitCanva : MonoBehaviour
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