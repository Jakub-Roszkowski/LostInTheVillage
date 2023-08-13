using System.Collections;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private GUN_Stats GUN_Stats;
    [SerializeField] private Transform fpsCam;
    [SerializeField] private ParticleSystem muzzleFlash;
    [SerializeField] private GameObject impactEffect;

    private float range;
    private float impactForce;
    private float damageAmount;

    public AudioSource BGM;
    private int fireRate = 10;
    private float nextTimeToFire = 0;

    private AudioClip shootSound;
    private AudioClip ReloudSound;
    private AudioClip headshoot;

    public int currentAmmo;
    private int magazineAmmo;
    private float reloadTime;
    private bool ISReloundig;
    private float shotgunHolesRandom = 0.3f;

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

        reloadTime = GUN_Stats.ReloadTime;

        shootSound = GUN_Stats.shoot;
        ReloudSound = GUN_Stats.ReloadSound;
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

    void Update()
    {
        if (Pause.currentLevel == Level.Easy)
        {
            damageAmount = GUN_Stats.Damage * 2;
        }
        else if (Pause.currentLevel == Level.Medium)
        {
            damageAmount = GUN_Stats.Damage;
        }
        else if (Pause.currentLevel == Level.Hard)
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
                    enemy.TakeDamage(damageAmount * 6);
                    StartCoroutine(wait_Head());
                }
            }
            //ENEMY_______________________________________________________________________________________________________________________________________________________________________________

            if (gameObject.CompareTag("shotgun"))
            {
                Quaternion impactRotation1 = Quaternion.LookRotation(hit.normal);
                GameObject impact1 = Instantiate(impactEffect, hit.point, impactRotation1);
                impact1.transform.parent = hit.transform;
                Destroy(impact1, 5);

                Vector3 offset2 = hit.normal * Random.Range(-shotgunHolesRandom, shotgunHolesRandom) + Vector3.up * Random.Range(-shotgunHolesRandom, shotgunHolesRandom) + Vector3.right * Random.Range(-shotgunHolesRandom, shotgunHolesRandom);
                Quaternion impactRotation2 = Quaternion.LookRotation(hit.normal);
                GameObject impact2 = Instantiate(impactEffect, hit.point + offset2, impactRotation2);
                impact2.transform.parent = hit.transform;
                Destroy(impact2, 5);

                Vector3 offset3 = hit.normal * Random.Range(-shotgunHolesRandom, shotgunHolesRandom) + Vector3.up * Random.Range(-shotgunHolesRandom, shotgunHolesRandom) + Vector3.right * Random.Range(-shotgunHolesRandom, shotgunHolesRandom);
                Quaternion impactRotation3 = Quaternion.LookRotation(hit.normal);
                GameObject impact3 = Instantiate(impactEffect, hit.point + offset3, impactRotation3);
                impact3.transform.parent = hit.transform;
                Destroy(impact3, 5);

                Vector3 offset4 = hit.normal * Random.Range(-shotgunHolesRandom, shotgunHolesRandom) + Vector3.up * Random.Range(-shotgunHolesRandom, shotgunHolesRandom) + Vector3.right * Random.Range(-shotgunHolesRandom, shotgunHolesRandom);
                Quaternion impactRotation4 = Quaternion.LookRotation(hit.normal);
                GameObject impact4 = Instantiate(impactEffect, hit.point + offset4, impactRotation4);
                impact4.transform.parent = hit.transform;
                Destroy(impact4, 5);

                Vector3 offset5 = hit.normal * Random.Range(-shotgunHolesRandom, shotgunHolesRandom) + Vector3.up * Random.Range(-shotgunHolesRandom, shotgunHolesRandom) + Vector3.right * Random.Range(-shotgunHolesRandom, shotgunHolesRandom);
                Quaternion impactRotation5 = Quaternion.LookRotation(hit.normal);
                GameObject impact5 = Instantiate(impactEffect, hit.point + offset5, impactRotation5);
                impact5.transform.parent = hit.transform;
                Destroy(impact5, 5);

                Vector3 offset6 = hit.normal * Random.Range(-shotgunHolesRandom, shotgunHolesRandom) + Vector3.up * Random.Range(-shotgunHolesRandom, shotgunHolesRandom) + Vector3.right * Random.Range(-shotgunHolesRandom, shotgunHolesRandom);
                Quaternion impactRotation6 = Quaternion.LookRotation(hit.normal);
                GameObject impact6 = Instantiate(impactEffect, hit.point + offset6, impactRotation6);
                impact6.transform.parent = hit.transform;
                Destroy(impact6, 5);
            }
            else
            {
                Quaternion impactRotation = Quaternion.LookRotation(hit.normal);
                GameObject impact = Instantiate(impactEffect, hit.point, impactRotation);
                impact.transform.parent = hit.transform;
                Destroy(impact, 5);
            }
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