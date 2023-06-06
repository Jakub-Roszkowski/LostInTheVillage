using System;
using UnityEngine;

public class DisappearinChicken : MonoBehaviour
{

    public AudioSource BGM;
    public AudioClip die;

    private void Start()
    {

}



    public void Disappear()
    {

        ChangeBGM(die);
        Invoke("HideObject", 0.7f);

    }

    public void ChangeBGM(AudioClip music)
    {



        BGM.Stop();
        BGM.clip = music;
        BGM.Play();

    }



    private void HideObject()
    {
        Destroy(gameObject);
    }
}