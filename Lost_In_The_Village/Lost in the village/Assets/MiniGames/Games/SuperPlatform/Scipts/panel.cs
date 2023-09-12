using UnityEngine;
using UnityEngine.UI;

namespace LostInTheVillage.MiniGames.Games.SuperPlatform.Scripts
{
    public class Panel : MonoBehaviour
    {
        [SerializeField] private Slider healtbar;

        private void Start ()
        {
            healtbar.maxValue = 100;
        }

        private void Update()
        {
            healtbar.value = PlayerPlatformController.Health;
        }
    }
}
