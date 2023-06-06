using System.Collections;
using UnityEngine.InputSystem;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GUN_Stats GUN_Stats;
    public Transform fpsCam;
    private float range;
    private float impactForce;
    private int damageAmount;

    public AudioSource BGM;
    private int fireRate = 10;
    private float nextTimeToFire = 0;

    private AudioClip shootSound;
    private AudioClip ReloudSound;

    public ParticleSystem muzzleFlash;
    public GameObject impactEffect;


    public int currentAmmo;

    private int magazineAmmo;

    private float reloadTime;

    private bool ISReloundig;


    private InputManagerToShoot inputManager;

    public GameObject lightObject;







    void Start()
    {

        ISReloundig = false;
        range = GUN_Stats.Range;
        impactForce = GUN_Stats.impactForce;
        damageAmount = GUN_Stats.Damage;
        fireRate = GUN_Stats.fireRate;
        magazineAmmo = GUN_Stats.MagazineAMMO;

        reloadTime = GUN_Stats.ReloudTime;



        shootSound = GUN_Stats.shoot;
        ReloudSound = GUN_Stats.ReloudSound;

        inputManager = GetComponent<InputManagerToShoot>();

        

        currentAmmo = magazineAmmo;
        SetAmmoCountForParent(currentAmmo);

        Light lightComponent = lightObject.GetComponent<Light>();
        if (lightComponent != null)
        {
            lightComponent.enabled = false;
        }


    }
    private void OnEnable()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.parent != null && transform.parent.name == "test")
        {


            bool isShooting = inputManager.onFoot.Shoot.triggered;

            if (currentAmmo == 0)
            {
                StartCoroutine(Reload());
            }


            bool isReloading = inputManager.onFoot.Reloud.triggered;

            if (isReloading)
            {
                StartCoroutine(Reload());
            }

            if (isShooting && Time.time >= nextTimeToFire && currentAmmo > 0 && !ISReloundig)
            {
                nextTimeToFire = Time.time + 1f / fireRate;
                Fire();
            }



        }
        SetAmmoCountForParent(currentAmmo);

    }

    private void Fire()
    {
        ChangeBGM(shootSound);
        muzzleFlash.Play();



        Light lightComponent = lightObject.GetComponent<Light>();
        if (lightComponent != null)
        {
            lightComponent.enabled = true; // W��cz �wiat�o podczas strza�u
            StartCoroutine(DisableLightAfterDelay(lightComponent, 0.1f)); // Wy��cz �wiat�o po op�nieniu
        }

        currentAmmo--;
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.position + fpsCam.forward, fpsCam.forward, out hit, range))
        {
            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }


            // Sprawd�, czy trafiony obiekt mo�e znikn��
            DisappearingObject disappearingObject = hit.collider.GetComponent<DisappearingObject>();
            if (disappearingObject != null)
            {
                // Wywo�aj metod�, kt�ra sprawi, �e obiekt zniknie
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
        ISReloundig = true;
        ChangeBGM(ReloudSound);
        yield return new WaitForSeconds(reloadTime);
        currentAmmo = magazineAmmo;
        ISReloundig = false;


    }

    IEnumerator DisableLightAfterDelay(Light light, float delay)
    {
        yield return new WaitForSeconds(delay);
        light.enabled = false; // Wy��cz �wiat�o po op�nieniu
    }




    public void ChangeBGM(AudioClip music)
    {
        BGM.Stop();
        BGM.clip = music;
        BGM.Play();

    }

    void SetAmmoCountForParent(int ammo)
    {
        GameObject parentObject = transform.parent.gameObject;
        if (parentObject != null)
        {
            AMMO ammoScript = parentObject.GetComponent<AMMO>();
            if (ammoScript != null)
            {
                ammoScript.AMMO_count = ammo;
            }
        }
    }
}

