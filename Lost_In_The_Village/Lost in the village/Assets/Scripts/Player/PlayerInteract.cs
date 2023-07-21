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
            if (hitInfo.collider.GetComponent<WeaponPickup>() != null)
            {
                WeaponPickup interactable = hitInfo.collider.GetComponent<WeaponPickup>();
                interactable.Interact(hitInfo.collider.gameObject);
                playerUI.UpdateText(interactable.promptMessage);
                if (inputManager.onFoot.Interact.triggered)
                {
                    interactable.Interact2(hitInfo.collider.gameObject);
                }
            }
            if (hitInfo.collider.GetComponent<Interactable_donut>() != null)
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
            else if (hitInfo.collider.GetComponent<InteractableCharacter>() != null)
            {
                InteractableCharacter interactable = hitInfo.collider.GetComponent<InteractableCharacter>();
                interactable.Interact();
                playerUI.UpdateText(interactable.promptMessage);
                if (inputManager.onFoot.Interact.triggered)
                {
                    interactable.Interact2();
                }
            }
            else if (hitInfo.collider.GetComponent<InteractableGameToIN>() != null)
            {
                InteractableGameToIN interactable = hitInfo.collider.GetComponent<InteractableGameToIN>();
                interactable.Interact();
                playerUI.UpdateText(interactable.promptMessage);
                if (inputManager.onFoot.Interact.triggered)
                {
                    interactable.Interact2();
                }
            }
            else if (hitInfo.collider.GetComponent<Plotka>() != null)
            {
                Plotka interactable = hitInfo.collider.GetComponent<Plotka>();
                interactable.Interact();
                playerUI.UpdateText(interactable.promptMessage);
                if (inputManager.onFoot.Interact.triggered)
                {
                    interactable.Interact2();
                }
            }
            else if (hitInfo.collider.GetComponent<Glasses>() != null)
            {
                Glasses interactable = hitInfo.collider.GetComponent<Glasses>();
                interactable.Interact();
                playerUI.UpdateText(interactable.promptMessage);
                if (inputManager.onFoot.Interact.triggered)
                {
                    interactable.Interact2();
                }
            }
            else if (hitInfo.collider.GetComponent<InteractableBackup>() != null)
            {
                InteractableBackup interactable = hitInfo.collider.GetComponent<InteractableBackup>();
                interactable.Interact();
                playerUI.UpdateText(interactable.promptMessage);
                if (inputManager.onFoot.Interact.triggered)
                {
                    interactable.Interact2();
                }
            }
            else if (hitInfo.collider.GetComponent<InteractableLaptop>() != null)
            {
                InteractableLaptop interactable = hitInfo.collider.GetComponent<InteractableLaptop>();
                interactable.Interact();
                playerUI.UpdateText(interactable.promptMessage);
                if (inputManager.onFoot.Interact.triggered)
                {
                    interactable.Interact2();
                }
            }
            else if (hitInfo.collider.GetComponent<DoorEvacuation>() != null)
            {
                DoorEvacuation interactable = hitInfo.collider.GetComponent<DoorEvacuation>();
                interactable.Interact();
                playerUI.UpdateText(interactable.promptMessage);
                if (inputManager.onFoot.Interact.triggered)
                {
                    interactable.Interact2();
                }
            }
            else if (hitInfo.collider.GetComponent<Control>() != null)
            {
                Control interactable = hitInfo.collider.GetComponent<Control>();
                interactable.Interact();
                playerUI.UpdateText(interactable.promptMessage);
                if (inputManager.onFoot.Interact.triggered)
                {
                    interactable.Interact2();
                }
            }









            //doors and windows
            else if (hitInfo.collider.GetComponent<SojaExiles.ClosetopencloseDoor>() != null)
            {
                SojaExiles.ClosetopencloseDoor interactable = hitInfo.collider.GetComponent<SojaExiles.ClosetopencloseDoor>();
                interactable.Interact();
                playerUI.UpdateText(interactable.promptMessage);
                if (inputManager.onFoot.Interact.triggered)
                {
                    interactable.Interact2();
                }
            }
            else if (hitInfo.collider.GetComponent<SojaExiles.opencloseDoor>() != null)
            {
                SojaExiles.opencloseDoor interactable = hitInfo.collider.GetComponent<SojaExiles.opencloseDoor>();
                interactable.Interact();
                playerUI.UpdateText(interactable.promptMessage);
                if (inputManager.onFoot.Interact.triggered)
                {
                    interactable.Interact2();
                }
            }
            else if (hitInfo.collider.GetComponent<SojaExiles.opencloseDoor1>() != null)
            {
                SojaExiles.opencloseDoor1 interactable = hitInfo.collider.GetComponent<SojaExiles.opencloseDoor1>();
                interactable.Interact();
                playerUI.UpdateText(interactable.promptMessage);
                if (inputManager.onFoot.Interact.triggered)
                {
                    interactable.Interact2();
                }
            }
            else if (hitInfo.collider.GetComponent<SojaExiles.opencloseSlide>() != null)
            {
                SojaExiles.opencloseSlide interactable = hitInfo.collider.GetComponent<SojaExiles.opencloseSlide>();
                interactable.Interact();
                playerUI.UpdateText(interactable.promptMessage);
                if (inputManager.onFoot.Interact.triggered)
                {
                    interactable.Interact2();
                }
            }
            else if (hitInfo.collider.GetComponent<SojaExiles.opencloseStallDoor>() != null)
            {
                SojaExiles.opencloseStallDoor interactable = hitInfo.collider.GetComponent<SojaExiles.opencloseStallDoor>();
                interactable.Interact();
                playerUI.UpdateText(interactable.promptMessage);
                if (inputManager.onFoot.Interact.triggered)
                {
                    interactable.Interact2();
                }
            }
            else if (hitInfo.collider.GetComponent<SojaExiles.opencloseWindow>() != null)
            {
                SojaExiles.opencloseWindow interactable = hitInfo.collider.GetComponent<SojaExiles.opencloseWindow>();
                interactable.Interact();
                playerUI.UpdateText(interactable.promptMessage);
                if (inputManager.onFoot.Interact.triggered)
                {
                    interactable.Interact2();
                }
            }
            else if (hitInfo.collider.GetComponent<SojaExiles.opencloseWindow1>() != null)
            {
                SojaExiles.opencloseWindow1 interactable = hitInfo.collider.GetComponent<SojaExiles.opencloseWindow1>();
                interactable.Interact();
                playerUI.UpdateText(interactable.promptMessage);
                if (inputManager.onFoot.Interact.triggered)
                {
                    interactable.Interact2();
                }
            }
            else if (hitInfo.collider.GetComponent<SojaExiles.opencloseWindowApt>() != null)
            {
                SojaExiles.opencloseWindowApt interactable = hitInfo.collider.GetComponent<SojaExiles.opencloseWindowApt>();
                interactable.Interact();
                playerUI.UpdateText(interactable.promptMessage);
                if (inputManager.onFoot.Interact.triggered)
                {
                    interactable.Interact2();
                }
            
            }
            else if (hitInfo.collider.GetComponent<SojaExiles.Drawer_Pull_X>() != null)
            {
                SojaExiles.Drawer_Pull_X interactable = hitInfo.collider.GetComponent<SojaExiles.Drawer_Pull_X>();
                interactable.Interact();
                playerUI.UpdateText(interactable.promptMessage);
                if (inputManager.onFoot.Interact.triggered)
                {
                    interactable.Interact2();
                }

            }
            else if (hitInfo.collider.GetComponent<SojaExiles.Drawer_Pull_Z>() != null)
            {
                SojaExiles.Drawer_Pull_Z interactable = hitInfo.collider.GetComponent<SojaExiles.Drawer_Pull_Z>();
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
