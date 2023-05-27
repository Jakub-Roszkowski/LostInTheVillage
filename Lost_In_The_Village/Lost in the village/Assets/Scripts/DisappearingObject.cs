using System;
using UnityEngine;

public class DisappearingObject : MonoBehaviour
{

    public int numberOfShoot = 5;
    public int numberOfShootGiven = 0;

    public ParticleSystem Fire;

    private void Start()
    {

        Fire.Pause(); // Zatrzymaj Particle System na starcie gry
        numberOfShoot = 5;
        numberOfShootGiven = 0;

}



    public void Disappear()
    {


        Fire.Play();
        if(numberOfShootGiven==numberOfShoot)
        Destroy(gameObject);

        numberOfShootGiven++;

    }
}