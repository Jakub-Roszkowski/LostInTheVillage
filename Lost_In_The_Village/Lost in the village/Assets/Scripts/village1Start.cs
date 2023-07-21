using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class village1Start : MonoBehaviour
{
    public InteractableCharacter InteractableCharacter;
    void Start()
    {
        CharacterMessage characterMessage = gameObject.GetComponent<CharacterMessage>();

        characterMessage.Message();
        StartCoroutine(wait());
    }

    void Update()
    {
        
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(0.5f);
        InteractableCharacter.to_see = true;
    }
}
