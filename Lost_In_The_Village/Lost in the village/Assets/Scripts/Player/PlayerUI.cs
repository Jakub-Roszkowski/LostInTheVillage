using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] private Health player;
    [SerializeField] private Slider health;
    [SerializeField] private TextMeshProUGUI promptText;
    [SerializeField] private TextMeshProUGUI AMMOText;

    void Start()
    {
        health.maxValue = 100;
        health.value = 100;
    }

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
        return 0;
    }
}
