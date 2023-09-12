using LostInTheVillage.Menus;
using LostInTheVillage.NPC.Chicken;
using System.Collections;
using UnityEngine;

namespace LostInTheVillage.Player
{
    public class Gun : MonoBehaviour
    {
        [SerializeField] private GUN_Stats GUN_Stats;
        [SerializeField] private Transform fpsCam;
        [SerializeField] private ParticleSystem muzzleFlash;
        [SerializeField] private GameObject impactEffect;
        [SerializeField] private AudioSource BGM;
        [SerializeField] private GameObject lightObject;

        private float range;
        private float impactForce;
        private float damageAmount;
        private int fireRate;
        private int magazineAmmo;
        private float reloadTime;

        private float nextTimeToFire = 0;
        private float shotgunHolesRandom = 0.3f;
        private bool isReloading;
        private int currentAmmo;

        private AudioClip shootSound;
        private AudioClip ReloudSound;
        private AudioClip headshoot;
        private InputManagerToShoot inputManager;

        private void Start()
        {
            isReloading = false;

            LoadGunStats();

            inputManager = GetComponent<InputManagerToShoot>();

            currentAmmo = magazineAmmo;
            SetAmmoCountForParent(currentAmmo);

            Light lightComponent = lightObject.GetComponent<Light>();
            if (lightComponent != null)
            {
                lightComponent.enabled = false;
            }
        }


        void Update()
        {
            UpdateDamageAmount();

            HandleShootingInput();
            HandleReloadInput();

            SetAmmoCountForParent(currentAmmo);
        }

        private void LoadGunStats()
        {
            range = GUN_Stats.Range;
            impactForce = GUN_Stats.impactForce;
            damageAmount = GUN_Stats.Damage;
            fireRate = GUN_Stats.fireRate;
            magazineAmmo = GUN_Stats.MagazineAMMO;
            reloadTime = GUN_Stats.ReloadTime;
            shootSound = GUN_Stats.shoot;
            ReloudSound = GUN_Stats.ReloadSound;
            headshoot = GUN_Stats.headshoot;
        }

        private void UpdateDamageAmount()
        {
            switch (Pause.CurrentLevel)
            {
                case Level.Easy:
                    damageAmount = GUN_Stats.Damage * 2;
                    break;
                case Level.Medium:
                    damageAmount = GUN_Stats.Damage;
                    break;
                case Level.Hard:
                    damageAmount = GUN_Stats.Damage * 0.5f;
                    break;
            }
        }
        #region Inputs
        private void HandleShootingInput()
        {
            if (transform.parent != null && transform.parent.name == "test" &&
                inputManager.OnFoot.Shoot.triggered &&
                Time.time >= nextTimeToFire &&
                currentAmmo > 0 &&
                !isReloading &&
                !Pause.GameIsPaused)
            {
                HandleShooting();
            }
        }

        private void HandleReloadInput()
        {
            if (transform.parent != null && transform.parent.name == "test" &&
                inputManager.OnFoot.Reloud.triggered)
            {
                StartCoroutine(Reload());
            }
        }
        #endregion

        private void HandleShooting()
        {
            nextTimeToFire = Time.time + 1f / fireRate;
            Fire();
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

                HandleHit(hit);

                if (gameObject.CompareTag("shotgun"))
                {
                    HandleShotgunImpact(hit);
                }
                else
                {
                    HandleDefaultImpact(hit);
                }
            }
            if (currentAmmo == 0)
            {
                StartCoroutine(Reload());
            }
        }
        #region HandleHit
        private void HandleHit(RaycastHit hit)
        {
            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }

            DisappearinChicken disappearingChicken = hit.collider.GetComponent<DisappearinChicken>();
            if (disappearingChicken != null)
            {
                disappearingChicken.Disappear();
            }

            if (hit.collider.CompareTag("Body"))
            {
                HandleEnemyDamage(hit, damageAmount);
            }
            else if (hit.collider.CompareTag("Head"))
            {
                HandleEnemyDamage(hit, damageAmount * 6);
                StartCoroutine(WaitForHeadshotSound());
            }
        }

        private void HandleEnemyDamage(RaycastHit hit, float damage)
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
                enemy.TakeDamage(damage);
            }
        }
        #endregion
        #region HandleImpact
        private void HandleShotgunImpact(RaycastHit hit)
        {
            for (int i = 0; i < 6; i++)
            {
                Vector3 offset = hit.normal * Random.Range(-shotgunHolesRandom, shotgunHolesRandom) +
                                 Vector3.up * Random.Range(-shotgunHolesRandom, shotgunHolesRandom) +
                                 Vector3.right * Random.Range(-shotgunHolesRandom, shotgunHolesRandom);

                Quaternion impactRotation = Quaternion.LookRotation(hit.normal);
                GameObject impact = Instantiate(impactEffect, hit.point + offset, impactRotation);
                impact.transform.parent = hit.transform;
                Destroy(impact, 5);
            }
        }

        private void HandleDefaultImpact(RaycastHit hit)
        {
            Quaternion impactRotation = Quaternion.LookRotation(hit.normal);
            GameObject impact = Instantiate(impactEffect, hit.point, impactRotation);
            impact.transform.parent = hit.transform;
            Destroy(impact, 5);
        }
        #endregion
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
                Ammo ammoScript = parentObject.GetComponent<Ammo>();
                if (ammoScript != null)
                {
                    ammoScript.AmmoCount = ammo;
                }
            }
        }

        #region IEnumerators
        IEnumerator WaitForHeadshotSound()
        {
            yield return new WaitForSeconds(0.2f);
            ChangeBGM(headshoot);
        }

        IEnumerator Reload()
        {
            isReloading = true;
            ChangeBGM(ReloudSound);
            yield return new WaitForSeconds(reloadTime);
            currentAmmo = magazineAmmo;
            isReloading = false;
        }

        IEnumerator DisableLightAfterDelay(Light light, float delay)
        {
            yield return new WaitForSeconds(delay);
            light.enabled = false;
        }
        #endregion
    }
}