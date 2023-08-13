using UnityEngine;

public class Hello : MonoBehaviour
{
    [SerializeField] private AudioSource BGM;
    [SerializeField] private AudioClip orzel;

    void Start()
    {
        BGM.Stop();
    }

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