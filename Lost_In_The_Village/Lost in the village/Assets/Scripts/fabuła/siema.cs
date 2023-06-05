using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class siema : MonoBehaviour
{


    public AudioSource BGM;
    public AudioClip orzel;


    void Start()
    {
        BGM.Stop();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        ChangeBGM(orzel);

    }
    public void OnTriggerExit(Collider other)
    {
        
    }

    public void OnTriggerStay(Collider other)
    {
        
    }




    public void ChangeBGM(AudioClip music)
    {



        BGM.Stop();
        BGM.clip = music;
        BGM.Play();

    }
}

