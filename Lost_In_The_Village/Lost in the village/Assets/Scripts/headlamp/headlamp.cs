using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class headlamp : MonoBehaviour
{


    public Light light;
    private InputManagerToHeadLamp inputManager;


    private bool ifactive;



    private void Start()
    {
        inputManager = GetComponent<InputManagerToHeadLamp>();
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
