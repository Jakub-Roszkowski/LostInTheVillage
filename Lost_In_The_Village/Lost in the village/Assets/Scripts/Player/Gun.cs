using System.Collections;
using UnityEngine.InputSystem;
using UnityEngine;
using System.Diagnostics;
using Debug = UnityEngine.Debug;

public class Gun : MonoBehaviour
{
    public GUN_Stats GUN_Stats;
    public Transform fpsCam;
    private float range;
    private float impactForce;
    private float damageAmount;

    public AudioSource BGM;
    private int fireRate = 10;
    private float nextTimeToFire = 0;

    private AudioClip shootSound;
    private AudioClip ReloudSound;
    private AudioClip headshoot;

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
        headshoot = GUN_Stats.headshoot;

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
        if(Pause.currentLevel == Level.Easy){
            damageAmount = GUN_Stats.Damage * 3;
        }
        if (Pause.currentLevel == Level.Medium)
        {
            damageAmount = GUN_Stats.Damage;
        }
        if (Pause.currentLevel == Level.Hard)
        {
            damageAmount = GUN_Stats.Damage * 0.5f;
        }
        if (transform.parent != null && transform.parent.name == "test")
        {


            bool isShooting = inputManager.onFoot.Shoot.triggered;




            bool isReloading = inputManager.onFoot.Reloud.triggered;

            if (isReloading)
            {
                StartCoroutine(Reload());
            }

            if (isShooting && Time.time >= nextTimeToFire && currentAmmo > 0 && !ISReloundig && !Pause.GameIsPaused)
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
            lightComponent.enabled = true;
            StartCoroutine(DisableLightAfterDelay(lightComponent, 0.1f));
        }

        currentAmmo--;
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.position + fpsCam.forward, fpsCam.forward, out hit, range))
        {
            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }



            //Chicken_______________________________________________________________________________________________________________________________________________________________________________
            DisappearinChicken disappearingChicken = hit.collider.GetComponent<DisappearinChicken>();
            if (disappearingChicken != null)
            {
                disappearingChicken.Disappear();
            }
            //Chicken________________________________________________________________________________________________________________________________________________________________________________

            //ENEMY_______________________________________________________________________________________________________________________________________________________________________________
            if (hit.collider.CompareTag("Body"))
            {
                Debug.Log("Body");
                Transform parent = hit.transform.parent;
                Health enemy = null;

                while (parent != null)
                {
                    enemy = parent.GetComponent<Health>();
                    if (enemy != null)
                        break;

                    parent = parent.parent;
                }
                if (enemy != null)
                {
                    enemy.TakeDamage(damageAmount);
                    Debug.Log(enemy.GetCurrentHealth());

                }
            }
            if (hit.collider.CompareTag("Head"))
            {
                Transform parent = hit.transform.parent;
                Health enemy = null;

                while (parent != null)
                {
                    enemy = parent.GetComponent<Health>();
                    if (enemy != null)
                        break;

                    parent = parent.parent;
                }
                if (enemy != null)
                {

                    enemy.TakeDamage(damageAmount * 4);
                    Debug.Log(enemy.GetCurrentHealth());
                    Debug.Log("Head");
                    StartCoroutine(wait_Head());

                }
            }
            //ENEMY_______________________________________________________________________________________________________________________________________________________________________________




            Quaternion impactRotation = Quaternion.LookRotation(hit.normal);
            GameObject impact = Instantiate(impactEffect, hit.point, impactRotation);
            impact.transform.parent = hit.transform;
            Destroy(impact, 5);
        }
        if (currentAmmo == 0)
        {
            StartCoroutine(Reload());
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
        light.enabled = false;
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


    IEnumerator wait_Head()
    {
        yield return new WaitForSeconds(0.2f);
        ChangeBGM(headshoot);
    }
}

