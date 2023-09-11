using LostInTheVillage.Character;
using LostInTheVillage.Interactable;
using System.Collections;
using UnityEngine;

namespace LostInTheVillage.SceneHelpers.SceneMenager
{
    public class Village1Start : MonoBehaviour
    {
        [SerializeField] private CharacterInteractable InteractableCharacter;

        private void Start()
        {
            CharacterMessage characterMessage = gameObject.GetComponent<CharacterMessage>();

            characterMessage.Message();
            StartCoroutine(Wait());
        }

        IEnumerator Wait()
        {
            yield return new WaitForSeconds(0.5f);
            InteractableCharacter.ToSee = true;
        }
    }
}
