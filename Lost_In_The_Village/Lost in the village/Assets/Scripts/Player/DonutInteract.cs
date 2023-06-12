using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonutInteract : Interactable_donut
{
    public AudioSource eatingSound;
    public bool iseat=true;
    private static int value = 20;

    private void Update()
    {
        if (Pause.currentLevel == Level.Easy)
        {
            value = 30;
        }
        if (Pause.currentLevel == Level.Medium)
        {
            value = 20;
        }
        if (Pause.currentLevel == Level.Hard)
        {
            value = 5;
        }
    }



    protected override void Interact()
    {
        // Check if the player has a Health component
        Health playerHealth = GameObject.FindWithTag("Player").GetComponent<Health>();


        if (playerHealth != null&&iseat)
        {
            // Restore 20 HP to the player
            playerHealth.RestoreHealth(value);
            eatingSound.Play();
            iseat = false;
            // Destroy the object
            Destroy(gameObject,1);
        }
    }
}
