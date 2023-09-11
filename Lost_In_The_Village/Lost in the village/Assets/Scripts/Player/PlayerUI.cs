using LostInTheVillage.Helpers;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace LostInTheVillage.Player
{
    public class PlayerUI : MonoBehaviour
    {
        [SerializeField] private Health player;
        [SerializeField] private Slider health;
        [SerializeField] private TextMeshProUGUI promptText;
        [SerializeField] private TextMeshProUGUI AMMOText;

        private void Start()
        {
            health.maxValue = ConfigNumbers.DefaultMaxHp;
            health.value = ConfigNumbers.DefaultMaxHp;
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
                    Ammo ammoScript = testChild.GetComponent<Ammo>();
                    if (ammoScript != null)
                    {
                        return ammoScript.AmmoCount;
                    }
                }
            }
            return 0;
        }
    }
}
