using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class panel : MonoBehaviour
{

    public Slider healtbar;
    // Start is called before the first frame update
    void Start()
    {
        healtbar.maxValue = 100;

        healtbar.value = 100;
    }

    // Update is called once per frame
    void Update()
    {
        healtbar.value = PlayerPlatform.health;
    }
}
