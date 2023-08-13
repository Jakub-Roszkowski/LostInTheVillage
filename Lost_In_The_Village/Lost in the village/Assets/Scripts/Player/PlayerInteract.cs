using UnityEngine;

public class PlayerInteract : MonoBehaviour
{   
    [SerializeField] private LayerMask mask;

    private Camera cam;
    private float distance = 8f;
    private PlayerUI playerUI;
    private InputManager inputManager;

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
            else if (hitInfo.collider.GetComponent<AbstractInteractableObject>() != null)
            {
                AbstractInteractableObject interactable = hitInfo.collider.GetComponent<AbstractInteractableObject>();
                interactable.Interact_();
                playerUI.UpdateText(interactable.promptMessage_());
                if (inputManager.onFoot.Interact.triggered)
                {
                    interactable.Interact2_();
                }
            }
        }
    }
}
