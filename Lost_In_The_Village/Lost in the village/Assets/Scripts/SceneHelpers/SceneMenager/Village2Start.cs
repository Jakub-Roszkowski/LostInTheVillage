using LostInTheVillage.Interactable;
using System.Collections;
using UnityEngine;

namespace LostInTheVillage.SceneHelpers.SceneMenager
{
    public class Village2Start : MonoBehaviour
    {
        [SerializeField] private CharacterInteractable InteractableCharacter;

        private void Start()
        {
            StartCoroutine(Wait());
        }

        private IEnumerator Wait()
        {
            yield return new WaitForSeconds(0.5f);
            InteractableCharacter.ToSee = true;
        }
    }
}
