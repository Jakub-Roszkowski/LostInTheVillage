using System.Collections;
using UnityEngine;

public class Village2Start : MonoBehaviour
{
    [SerializeField] private CharacterInteractable InteractableCharacter;
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
