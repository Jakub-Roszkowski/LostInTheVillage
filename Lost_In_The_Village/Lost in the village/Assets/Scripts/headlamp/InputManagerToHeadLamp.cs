using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManagerToHeadLamp : MonoBehaviour
{

    private PlayerInput playerInput;
    public PlayerInput.OnFootActions onFoot;
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
