using UnityEngine;

namespace LostInTheVillage.MiniGames.Games.SuperPlatform.Scripts
{
    public class Camera : MonoBehaviour
    {
        [SerializeField] private GameObject player;

        private void Update()
        {
            transform.position = new Vector3(player.transform.position.x, (player.transform.position.y + 1), -10);
        }
    }
}
