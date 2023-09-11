using LostInTheVillage.Helpers;
using UnityEngine;

namespace LostInTheVillage.Player
{
    public class PlayerMotor : MonoBehaviour
    {
        private CharacterController controller;
        private Vector3 playerVelocity;
        private bool isGrounded;
        private float speed = ConfigNumbers.Speed;
        private float runSpeed = ConfigNumbers.RunSpeed;
        private float gravity = ConfigNumbers.Gravity;
        private float jumpHeight = ConfigNumbers.JumpHeight;

        private void Start()
        {
            controller = GetComponent<CharacterController>();
        }

        private void Update()
        {
            isGrounded = controller.isGrounded;
        }

        public void ProcessMove(Vector2 input, bool isRunning)
        {
            Vector3 moveDirection = Vector3.zero;
            moveDirection.x = input.x;
            moveDirection.z = input.y;

            float currentSpeed = speed;
            if (isRunning)
            {
                currentSpeed = runSpeed;
            }

            controller.Move(transform.TransformDirection(moveDirection) * currentSpeed * Time.deltaTime);
            playerVelocity.y += gravity * Time.deltaTime;
            if (isGrounded && playerVelocity.y < 0)
                playerVelocity.y = -2f;
            controller.Move(playerVelocity * Time.deltaTime);
        }

        public void Jump()
        {
            if (isGrounded)
            {
                playerVelocity.y = Mathf.Sqrt(jumpHeight * -3.0f * gravity);
            }
        }
    }
}