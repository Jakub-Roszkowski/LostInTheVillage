using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{

    private float glosnosc;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        glosnosc = audioSource.volume;

    }

    // Update is called once per frame
    void Update()
    {
        if (Pause.GameIsPaused)
        {
            audioSource.volume = 0f;
        }
        else
        {
            audioSource.volume = glosnosc;
        }

        if (Pause.SoundisMute)
        {
            audioSource.volume = 0f;
        }
        else
        {
            audioSource.volume = glosnosc;
        }
    }
}
