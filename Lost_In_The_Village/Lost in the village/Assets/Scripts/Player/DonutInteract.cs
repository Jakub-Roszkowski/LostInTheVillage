using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonutInteract : Interactable
{
    public AudioSource eatingSound;
    public bool iseat=true;

    protected override void Interact()
    {
        // Check if the player has a Health component
        Health playerHealth = GameObject.FindWithTag("Player").GetComponent<Health>();

        if (playerHealth != null&&iseat)
        {
            // Restore 10 HP to the player
            playerHealth.RestoreHealth(10);
            
            eatingSound.Play();
            iseat = false;
            // Destroy the object
            Destroy(gameObject,1);
        }
    }
}
