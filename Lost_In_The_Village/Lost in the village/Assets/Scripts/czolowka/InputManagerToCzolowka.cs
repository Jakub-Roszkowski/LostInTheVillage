using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManagerToCzolowka : MonoBehaviour
{

    private PlayerInput playerInput;
    public PlayerInput.OnFootActions onFoot;
    // Start is called before the first frame update
    void Awake()
    {
        playerInput = new PlayerInput();
        onFoot = playerInput.OnFoot;

    }

    // Update is called once per frame
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
