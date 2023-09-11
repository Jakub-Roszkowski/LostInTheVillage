using UnityEngine;
using UnityEngine.UI;

namespace LostInTheVillage.MiniGames.Games.SuperPlatform.Scripts
{
    public class Panel : MonoBehaviour
    {
        public Slider healtbar;

        private void Update()
        {
            healtbar.value = PlayerPlatform.health;
        }
    }
}
