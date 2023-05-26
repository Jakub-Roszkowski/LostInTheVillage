using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : MonoBehaviour
{
    public ParticleSystem Fire;


    void Start()
    {
        Fire.Pause();
    }

    // Update is called once per frame
    void Update()
    {

    }
    //________________________________________________________NIE DZIA£A______________________________________________________________
    public void OnTriggerEnter(Collider other)
    {
        Fire.Play();
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerTakeDemage objectTODemage = other.GetComponent<PlayerTakeDemage>();

            objectTODemage.TakeDemage(30);
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

        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);



    }
}

