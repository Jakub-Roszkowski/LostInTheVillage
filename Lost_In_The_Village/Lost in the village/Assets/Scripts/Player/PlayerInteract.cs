using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    private Camera cam;

    private float distance = 8f;
    [SerializeField]
    private LayerMask mask;
    private PlayerUI playerUI;
    private InputManager inputManager;
    // Start is called before the first frame update Unity Message | 0 references
    void Start()
    {
        cam = GetComponent<PlayerLook>().cam;
        playerUI = GetComponent<PlayerUI>();
        inputManager = GetComponent<InputManager>();


    }

    void Update()
    {
        playerUI.UpdateText(string.Empty);
        //create a ray at the center of the camera, shooting outwards.
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * distance);
        RaycastHit hitInfo; // variable to store our collision information.

        if (Physics.Raycast(ray, out hitInfo, distance, mask))
        {
            if (hitInfo.collider.GetComponent<Interactable>() != null)
            {
                Interactable interactable = hitInfo.collider.GetComponent<Interactable>();
                playerUI.UpdateText(interactable.promptMessage);
                if (inputManager.onFoot.Interact.triggered)
                {
                    interactable.BaseInteract();
                }
            }
            else if (hitInfo.collider.GetComponent<Interactable_donut>() != null)
            {
                Interactable_donut interactable = hitInfo.collider.GetComponent<Interactable_donut>();
                interactable.BaseInteract1();
                playerUI.UpdateText(interactable.promptMessage);
                if (inputManager.onFoot.Interact.triggered)
                {
                    interactable.BaseInteract();
                }
            }
            else if (hitInfo.collider.GetComponent<Interactable_wine>() != null)
            {
                Interactable_wine interactable = hitInfo.collider.GetComponent<Interactable_wine>();
                interactable.BaseInteract1();
                playerUI.UpdateText(interactable.promptMessage);
                if (inputManager.onFoot.Interact.triggered)
                {
                    interactable.BaseInteract();
                }
            }
            else if (hitInfo.collider.GetComponent<Interactable_game_console>() != null)
            {
                Interactable_game_console interactable = hitInfo.collider.GetComponent<Interactable_game_console>();
                interactable.BaseInteract1();
                playerUI.UpdateText(interactable.promptMessage);
                if (inputManager.onFoot.Interact.triggered)
                {
                    interactable.BaseInteract();
                }
            }
            else if (hitInfo.collider.GetComponent<Interactable_Character>() != null)
            {
                Interactable_Character interactable = hitInfo.collider.GetComponent<Interactable_Character>();
                interactable.Interact();
                playerUI.UpdateText(interactable.promptMessage);
                if (inputManager.onFoot.Interact.triggered)
                {
                    interactable.Interact2();
                }
            }
        }

    }
}
