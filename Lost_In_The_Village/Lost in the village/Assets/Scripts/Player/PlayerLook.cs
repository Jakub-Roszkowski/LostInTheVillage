using LostInTheVillage.Helpers;
using UnityEngine;
using UnityEngine.InputSystem;

namespace LostInTheVillage.Player
{
    public class PlayerLook : MonoBehaviour
    {
        public Camera cam;

        public float mouseXSensitivity = ConfigNumbers.MouseXSensitivity;
        public float mouseYSensitivity = ConfigNumbers.MouseYSensitivity;
        public float gamepadXSensitivity = ConfigNumbers.GamepadXSensitivity;
        public float gamepadYSensitivity = ConfigNumbers.GamepadYSensitivity;

        private float xSensitivity;
        private float ySensitivity;

        private float xRotation = 0f;

        private void Start()
        {
            xSensitivity = mouseXSensitivity;
            ySensitivity = mouseYSensitivity;
        }

        public void ProcessLook(Vector2 input)
        {
            float mouseX = input.x;
            float mouseY = input.y;

            // Check Gamepad
            if (Gamepad.current != null && Gamepad.current.rightStick.ReadValue() != Vector2.zero)
            {
                xSensitivity = gamepadXSensitivity;
                ySensitivity = gamepadYSensitivity;
            }
            else
            {
                xSensitivity = mouseXSensitivity;
                ySensitivity = mouseYSensitivity;
            }

            mouseX *= xSensitivity;
            mouseY *= ySensitivity;

            xRotation -= (mouseY * Time.deltaTime);
            xRotation = Mathf.Clamp(xRotation, -80f, 80f);

            cam.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);

            transform.Rotate(Vector3.up * (mouseX * Time.deltaTime));
        }
    }
}