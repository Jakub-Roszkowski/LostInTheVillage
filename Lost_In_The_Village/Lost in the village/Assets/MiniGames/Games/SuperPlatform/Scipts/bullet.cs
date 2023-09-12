using UnityEngine;

namespace LostInTheVillage.MiniGames.Games.SuperPlatform.Scripts
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D rigidbody;

        private float movementSpeed = 1500;

        private void FixedUpdate()
        {
            rigidbody.velocity = transform.right * movementSpeed * Time.fixedDeltaTime;
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.collider.CompareTag("Block"))
            {
                Destroy(collision.collider.gameObject);
                Destroy(gameObject);
            }
            if (collision.collider)
            {
                Destroy(gameObject);
            }
        }
    }
}