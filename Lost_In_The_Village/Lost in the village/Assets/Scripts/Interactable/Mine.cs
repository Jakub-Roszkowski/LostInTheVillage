using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : MonoBehaviour
{
    public ParticleSystem Fire;

    public AudioSource BGM;
    public AudioClip boom;


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
        ChangeBGM(boom);
        Fire.Play();
        if (other.gameObject.CompareTag("Player"))
        {
            Health objectTODemage = other.GetComponent<Health>();
            objectTODemage.TakeDamage(10);
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

