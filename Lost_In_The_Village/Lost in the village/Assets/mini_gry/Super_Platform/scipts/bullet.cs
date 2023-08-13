using UnityEngine;

public class bullet : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public float movementSpeed;

    public PlayerPlatform player;

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



