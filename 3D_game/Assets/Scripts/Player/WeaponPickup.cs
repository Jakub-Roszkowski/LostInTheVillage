using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WeaponPickup : MonoBehaviour
{
    public Camera playerCamera; // Referencja do kamery gracza
    public Transform weaponSocket; // Referencja do punktu do��czenia broni do postaci
    public LayerMask pickupLayerMask; // Warstwa u�ywana do wykrywania broni do podniesienia

    public GameObject currentWeapon; // Obecna bro� postaci

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
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

        weapon.transform.localPosition = new Vector3(0.18f, -0.298f, 0.38273f); // Zresetuj pozycj� lokaln� broni
        weapon.transform.localRotation = Quaternion.Euler(0f, -12f, -14f); // Ustaw konkretn� rotacj� broni
        weapon.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f); // Ustaw skal� broni


        currentWeapon = weapon;
    }

    private void DropWeapon()
    {
        currentWeapon.SetActive(false); 
        currentWeapon.transform.SetParent(null); // Usu� rodzica dla broni

        currentWeapon = null;
    }
}
