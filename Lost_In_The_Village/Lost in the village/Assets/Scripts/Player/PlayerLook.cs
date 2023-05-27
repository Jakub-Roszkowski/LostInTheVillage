using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerLook : MonoBehaviour
{
    public Camera cam;
    private float xRotation = 0f;
    public float mouseXSensitivity = 10f;
    public float mouseYSensitivity = 10f;
    public float gamepadXSensitivity = 95f;
    public float gamepadYSensitivity = 95f;

    private float xSensitivity;
    private float ySensitivity;

    private void Start()
    {
        xSensitivity = mouseXSensitivity;
        ySensitivity = mouseYSensitivity;
    }

    public void ProcessLook(Vector2 input)
    {
        float mouseX = input.x;
        float mouseY = input.y;

        // Sprawdzanie, czy u�ywane jest urz�dzenie typu Gamepad
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

        // Mno�enie warto�ci osi przez odpowiednie czu�o�ci
        mouseX *= xSensitivity;
        mouseY *= ySensitivity;

        // Obliczanie rotacji kamery dla ruchu w g�r� i w d�
        xRotation -= (mouseY * Time.deltaTime);
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);

        // Zastosowanie rotacji do transformacji kamery
        cam.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);

        // Obr�t gracza w lewo i w prawo
        transform.Rotate(Vector3.up * (mouseX * Time.deltaTime));
    }
}