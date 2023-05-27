using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    public Player player;
    public Slider healtbar;
    [SerializeField]
    private TextMeshProUGUI promptText;
    [SerializeField]
    private TextMeshProUGUI AMMOText;
    // Start is called before the first frame update
    void Start()
    {
        healtbar.maxValue = 100;

        healtbar.value = 100;
    }

    // Update is called once per frame
    public void UpdateText(string promptMessage)
    {
        promptText.text = promptMessage;

    }
    public void Update()
    {
        healtbar.value = player.health;
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

        return 0; // Jeœli nie znaleziono obiektu "test" lub komponentu AMMO, zwróæ 0
    }
}
