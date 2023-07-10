using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WineInteract : Interactable_wine
{
    public AudioSource eatingSound;
    public bool iseat = true;

    private void Update()
    {

    }



    protected override void Interact()
    {
        drunk playerdrunk = GameObject.FindWithTag("MainCamera").GetComponent<drunk>();


        if (playerdrunk != null && iseat)
        {

            playerdrunk.DrunkEffect();
            eatingSound.Play();
            iseat = false;
            // Destroy the object
            Destroy(gameObject, 1);
        }
    }
}
