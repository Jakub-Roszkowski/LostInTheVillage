using LostInTheVillage.Helpers;
using LostInTheVillage.Interactable;
using LostInTheVillage.Interactable.Interface;
using UnityEngine;

namespace LostInTheVillage.Player
{
    public class PlayerInteract : MonoBehaviour
    {
        [SerializeField] private LayerMask mask;

        private Camera cam;
        private float distance = ConfigNumbers.InteractDistance;
        private PlayerUI playerUI;
        private InputManager inputManager;

        private void Start()
        {
            cam = GetComponent<PlayerLook>().cam;
            playerUI = GetComponent<PlayerUI>();
            inputManager = GetComponent<InputManager>();
        }

        private void Update()
        {
            playerUI.UpdateText(string.Empty);
            Ray ray = new Ray(cam.transform.position, cam.transform.forward);
            Debug.DrawRay(ray.origin, ray.direction * distance);
            RaycastHit hitInfo;

            if (Physics.Raycast(ray, out hitInfo, distance, mask))
            {
                if (hitInfo.collider.GetComponent<WeaponPickup>() != null)
                {
                    WeaponPickup interactable = hitInfo.collider.GetComponent<WeaponPickup>();
                    interactable.Interact(hitInfo.collider.gameObject);
                    playerUI.UpdateText(interactable.PromptMessage);
                    if (inputManager.OnFoot.Interact.triggered)
                    {
                        interactable.Interact2(hitInfo.collider.gameObject);
                    }
                }
                else if (hitInfo.collider.GetComponent<AbstractInteractableObject>() != null)
                {
                    AbstractInteractableObject interactable = hitInfo.collider.GetComponent<AbstractInteractableObject>();
                    interactable.Interact_();
                    playerUI.UpdateText(interactable.PromptMessage_());
                    if (inputManager.OnFoot.Interact.triggered)
                    {
                        interactable.Interact2_();
                    }
                }
            }
        }
    }
}
