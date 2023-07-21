using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Village2Start : MonoBehaviour
{
    public InteractableCharacter InteractableCharacter;
    void Start()
    {
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
