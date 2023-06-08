using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    public Health player;
    public Slider health;
    [SerializeField]
    private TextMeshProUGUI promptText;
    [SerializeField]
    private TextMeshProUGUI AMMOText;
    // Start is called before the first frame update
    void Start()
    {
        health.maxValue = 100;

        health.value = 100;
    }

    // Update is called once per frame
    public void UpdateText(string promptMessage)
    {
        promptText.text = promptMessage;

    }
    public void Update()
    {
        health.value = player.GetCurrentHealth();
        AMMOText.text = GetAmmoCount().ToString();
    }


    private int GetAmmoCount()
    {
        GameObject mainCamera = GameObject.Find("Main Camera");
        if (mainCamera != null)
        {
            Transform testChild = mainCamera.transform.Find("test");
            if (testChild != null)
            {
                AMMO ammoScript = testChild.GetComponent<AMMO>();
                if (ammoScript != null)
                {
                    return ammoScript.AMMO_count;
                }
            }
        }

        return 0; // Je�li nie znaleziono obiektu "test" lub komponentu AMMO, zwr�� 0
    }
}
