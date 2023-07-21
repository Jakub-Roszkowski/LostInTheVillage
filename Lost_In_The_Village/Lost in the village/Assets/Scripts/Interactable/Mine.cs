using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : MonoBehaviour
{
    public ParticleSystem Fire;

    public AudioSource BGM;
    public AudioClip boom;
    private float demage;


    void Start()
    {
        BGM.Stop();
        Fire.Pause();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (Pause.currentLevel == Level.Easy)
        {
            demage = 5;
        }
        else if (Pause.currentLevel == Level.Medium)
        {
            demage = 10;
        }
        else if (Pause.currentLevel == Level.Hard)
        {
            demage = 20;
        }


        ChangeBGM(boom);
        Fire.Play();
        if (other.gameObject.CompareTag("Player"))
        {
            Health objectTODemage = other.GetComponent<Health>();
            objectTODemage.TakeDamage(demage);
        }
        StartCoroutine(DestroyOBJ());
    }
    public void OnTriggerExit(Collider other)
    {
        
    }

    public void OnTriggerStay(Collider other)
    {
        
    }


    IEnumerator DestroyOBJ()
    {

        yield return new WaitForSeconds(4f);
        Destroy(gameObject);



    }

    public void ChangeBGM(AudioClip music)
    {



        BGM.Stop();
        BGM.clip = music;
        BGM.Play();

    }
}

