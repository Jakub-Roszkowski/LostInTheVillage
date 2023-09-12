using LostInTheVillage.Helpers;
using LostInTheVillage.Menus;
using LostInTheVillage.Player;
using System.Collections;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Vector3 = UnityEngine.Vector3;

namespace LostInTheVillage.NPCOpponents.EnemyBrainSmart
{
    public class EnemyShooter : MonoBehaviour
    {
        //toSounds
        public AudioSource shootSound;
        public AudioSource reloadSound;

        [Header("General")]
        public Transform shootPoint; //Where the raycast starts from
        public Transform gunPoint; //Where the visual trial starts from
        public LayerMask layerMask;

        [Header("Gun")]
        public Vector3 spread = new Vector3(0.06f, 0.06f, 0.06f);
        public TrailRenderer bulletTrail;
        public int ammo = 30;
        private EnemyReferences enemyReferences;
        private int currentAmmo;

        private float demage = 5;


        private Health playerHealth;

        public Transform target;


        private void Awake()
        {
            enemyReferences = GetComponent<EnemyReferences>();
            Reload();
        }

        private void Update()
        {
            if (Pause.CurrentLevel == Level.Easy)
            {
                demage = ConfigNumbers.EnemyDamageEasy;
            }
            if (Pause.CurrentLevel == Level.Medium)
            {
                demage = ConfigNumbers.EnemyDamageMedium;
            }
            if (Pause.CurrentLevel == Level.Hard)
            {
                demage = ConfigNumbers.EnemyDamageHard;
            }
        }

        public void Shoot()
        {

            if (ShouldReload())
                return;

            Vector3 direction = GetDirection();
            Vector3 shootPointPosition = shootPoint.position;

            RaycastHit hit;
            if (Physics.Raycast(shootPointPosition, direction, out hit, float.MaxValue, layerMask))
            {

                // Check if the hit object is the player and if it's visible
                if (hit.collider.CompareTag("Player"))
                {
                    shootSound.Play();
                    UnityEngine.Debug.DrawLine(shootPointPosition, hit.point, Color.red, 1f);

                    TrailRenderer trail = Instantiate(bulletTrail, gunPoint.position, Quaternion.identity);
                    StartCoroutine(SpawnTrial(trail, hit));

                    currentAmmo -= 3;

                    Health playerHealth = hit.collider.GetComponent<Health>();
                    if (playerHealth != null)
                    {
                        playerHealth.TakeDamage(demage);
                    }
                }
            }
        }

        private bool IsVisible(GameObject targetObject)
        {
            Vector3 direction = targetObject.transform.position - transform.position;
            if (Physics.Raycast(transform.position, direction, out RaycastHit hit, layerMask))
            {
                if (hit.collider.gameObject == targetObject)
                {
                    return true;
                }
            }
            return false;
        }


        private Vector3 GetDirection()
        {
            Vector3 direction = transform.forward;

            direction += new Vector3(
                Random.Range(-spread.x, spread.x),
                Random.Range(-spread.y, spread.y),
                Random.Range(-spread.z, spread.z)
                );

            //direction.Normalize();
            return direction;
        }


        private IEnumerator SpawnTrial(TrailRenderer trial, RaycastHit hit)
        {

            float time = 0f;

            Vector3 startPosition = trial.transform.position;

            while (time < 1f)
            {
                trial.transform.position = Vector3.Lerp(startPosition, hit.point, time);
                time += Time.deltaTime / trial.time;

                yield return null;
            }

            trial.transform.position = hit.point;

            Destroy(trial.gameObject, trial.time);
        }

        public bool ShouldReload()
        {

            return currentAmmo <= 0;
        }

        public void Reload()
        {
            currentAmmo = ammo;
            //reloadSound.Play();
        }
        public void Reload2()
        {
            //currentAmmo = ammo;
            reloadSound.Play();
        }
    }
}
