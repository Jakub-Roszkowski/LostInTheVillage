using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Pobierz komponent życia gracza
            PlayerTakeDemage playerHealth = collision.gameObject.GetComponent<PlayerTakeDemage>();

            if (playerHealth != null)
            {
                // Odejmij życie gracza
                playerHealth.TakeDemage(10);
            }
        }

        Destroy(gameObject);
    }
}
