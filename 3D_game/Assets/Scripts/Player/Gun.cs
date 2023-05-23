using System.Collections;
using UnityEngine.InputSystem;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform fpsCam;
    public float range = 20;
    public float impactForce = 150;
    public int damageAmount = 20;

    public int fireRate = 10;
    private float nextTimeToFire = 0;

    public ParticleSystem muzzleFlash;
    public GameObject impactEffect;

    public int currentAmmo;
    public int maxAmmo = 10;
    public int magazineAmmo = 30;

    public float reloadTime = 2f;
    public bool isReloading;

    //public Animator animator;

    InputAction shoot;

    private InputManager inputManager;

    public GameObject lightObject;


    void Start()
    {
        inputManager = GetComponent<InputManager>();
        shoot = inputManager.onFoot.Interact;
        shoot.Enable();

        currentAmmo = maxAmmo;

        Light lightComponent = lightObject.GetComponent<Light>();
        if (lightComponent != null)
        {
            lightComponent.enabled = false;
        }


    }
    private void OnEnable()
    {
        isReloading = false;
        //animator.SetBool("isReloading", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentAmmo == 0 && magazineAmmo == 0)
        {
            //animator.SetBool("isShooting", false);
            return;
        }

        if (isReloading)
            return;

        bool isShooting = inputManager.onFoot.Shoot.triggered;
        //animator.SetBool("isShooting", isShooting);

        if (isShooting && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f / fireRate;
            Fire();
        }

        if (currentAmmo == 0 && magazineAmmo > 0 && !isReloading)
        {
            StartCoroutine(Reload());
        }

    }

    private void Fire()
    {
        //AudioManager.instance.Play("Shoot");




        muzzleFlash.Play();



        Light lightComponent = lightObject.GetComponent<Light>();
        if (lightComponent != null)
        {
            lightComponent.enabled = true; // W³¹cz œwiat³o podczas strza³u
            StartCoroutine(DisableLightAfterDelay(lightComponent, 0.1f)); // Wy³¹cz œwiat³o po opóŸnieniu
        }

        currentAmmo--;
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.position + fpsCam.forward, fpsCam.forward, out hit, range))
        {
            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }

            //Enemy e = hit.transform.GetComponent<Enemy>();
            //if (e != null)
            //{
            //    e.TakeDamage(damageAmount);
            //    return;
            //}


                // SprawdŸ, czy trafiony obiekt mo¿e znikn¹æ
                DisappearingObject disappearingObject = hit.collider.GetComponent<DisappearingObject>();
                if (disappearingObject != null)
                {
                    // Wywo³aj metodê, która sprawi, ¿e obiekt zniknie
                    disappearingObject.Disappear();
                }


            Quaternion impactRotation = Quaternion.LookRotation(hit.normal);
            GameObject impact = Instantiate(impactEffect, hit.point, impactRotation);
            impact.transform.parent = hit.transform;
            Destroy(impact, 5);
        }
    }

    IEnumerator Reload()
    {
        isReloading = true;
        //AudioManager.instance.Play("Reload");
        //animator.SetBool("isReloading", true);
        yield return new WaitForSeconds(reloadTime);
        //animator.SetBool("isReloading", false);
        if (magazineAmmo >= maxAmmo)
        {
            currentAmmo = maxAmmo;
            magazineAmmo -= maxAmmo;
        }
        else
        {
            currentAmmo = magazineAmmo;
            magazineAmmo = 0;
        }
        isReloading = false;
    }

    IEnumerator DisableLightAfterDelay(Light light, float delay)
    {
        yield return new WaitForSeconds(delay);
        light.enabled = false; // Wy³¹cz œwiat³o po opóŸnieniu
    }
}
