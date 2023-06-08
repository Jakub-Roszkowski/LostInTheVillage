using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class czolowka : MonoBehaviour
{


    public Light light;
    private InputManagerToCzolowka inputManager;


    private bool ifactive;



    private void Start()
    {
        inputManager = GetComponent<InputManagerToCzolowka>();
        ifactive = true;
    }

    private void Update()
    {
        if (inputManager.onFoot.Light.triggered) 
        {
            light.gameObject.SetActive(!ifactive);
            ifactive = !ifactive;
        }
    }

}
