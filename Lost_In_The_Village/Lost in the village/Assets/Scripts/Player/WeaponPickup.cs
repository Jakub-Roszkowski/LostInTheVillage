using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WeaponPickup : MonoBehaviour
{
    public Camera playerCamera; // Referencja do kamery gracza
    public Transform weaponSocket; // Referencja do punktu do��czenia broni do postaci
    public LayerMask pickupLayerMask; // Warstwa u�ywana do wykrywania broni do podniesienia

    public GameObject currentWeapon; // Obecna bro� postaci


    private InputManager inputManager;

    private void Start()
    {
        inputManager = GetComponent<InputManager>();
        
    }

    private void Update()
    {
        if (inputManager.onFoot.Interact.triggered)
        {
            TryPickupWeapon();
        }
    }

    private void TryPickupWeapon()
    {
        Ray ray = playerCamera.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0f));

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, Mathf.Infinity, pickupLayerMask))
        {
            GameObject weaponToPickup = hit.collider.gameObject;

            if (currentWeapon != null)
            {
                DropWeapon();
            }

            PickupWeapon(weaponToPickup);
        }
    }

    private void PickupWeapon(GameObject weapon)
    {
        weapon.SetActive(true); // Wy��cz broni� podnoszon� z ziemi

        weapon.transform.SetParent(weaponSocket); // Ustaw rodzica dla broni na punkt do��czenia
        if (weapon.CompareTag("AK47"))
        {
            weapon.transform.localPosition = new Vector3(0.18f, -0.298f, 0.38273f); // Zresetuj pozycj� lokaln� broni
            weapon.transform.localRotation = Quaternion.Euler(0f, -12f, -14f); // Ustaw konkretn� rotacj� broni
            weapon.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f); // Ustaw skal� broni
        }
        else if (weapon.CompareTag("M4A1"))
        {
            weapon.transform.localPosition = new Vector3(0.1431269f, -0.298f, 0.3827395f); // Zresetuj pozycj� lokaln� broni
            weapon.transform.localRotation = Quaternion.Euler(-3.328f, 172.462f, -40.959f); // Ustaw konkretn� rotacj� broni
            weapon.transform.localScale = new Vector3(0.8175049f, 0.8234f, 0.8001348f); // Ustaw skal� broni
        }


        currentWeapon = weapon;
    }

    private void DropWeapon()
    {
        currentWeapon.SetActive(false); 
        currentWeapon.transform.SetParent(null); // Usu� rodzica dla broni

        currentWeapon = null;
    }
}
