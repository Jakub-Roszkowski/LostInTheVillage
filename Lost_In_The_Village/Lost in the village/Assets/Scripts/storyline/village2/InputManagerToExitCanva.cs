using UnityEngine;

namespace LostInTheVillage.Storyline.Village2
{
    public class InputManagerToExitCanva : MonoBehaviour
    {
        private PlayerInput playerInput;
        public PlayerInput.OnFootActions onFoot;

        private void Awake()
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
    }
}