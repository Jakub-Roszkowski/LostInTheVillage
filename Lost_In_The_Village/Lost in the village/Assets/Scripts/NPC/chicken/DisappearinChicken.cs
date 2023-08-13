using UnityEngine;

public class DisappearinChicken : MonoBehaviour
{
    [SerializeField] private AudioSource BGM;
    [SerializeField] private AudioClip die;

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